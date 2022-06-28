open System
open System.Net
open System.Reflection
open Grains
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Logging
open OpenTelemetry.Exporter
open OpenTelemetry.Metrics
open OpenTelemetry.Resources
open OpenTelemetry.Trace
open Orleans.Configuration
open Orleans.Hosting
open Orleans.Statistics
open Orleans
open Library.OrleansConfiguration
open OrleansDashboard

[<EntryPoint>]
let main args =
    let portsAsync =
        async {
            let tasks =
                [ Ports.siloPort ()
                  Ports.gatewayPort ()
                  Ports.primarySiloPort ()
                  Ports.dashboardPort ()
                  Ports.testsApiPort () ]

            let! results = tasks |> Async.Parallel

            let siloPort = results.[0]
            let gatewayPort = results.[1]
            let primarySiloPort = results.[2]
            let dashboardPort = results.[3]
            let smokeTestsApiPort = results.[4]
            
            let stringTasks = [Ports.clusterName ()
                               Ports.serviceName ()
                               Ports.prometheusHostAddress()]
            
            let! stringResults = stringTasks |> Async.Parallel
            
            let clusterName = stringResults.[0]
            let serviceName = stringResults.[1]
            let prometheusAddress = stringResults.[2]

            return siloPort, gatewayPort, primarySiloPort, dashboardPort, smokeTestsApiPort, clusterName, serviceName, prometheusAddress
        }

    let ipAddress =
        IpAddresses.advertisedIpAddress ()
        |> Async.RunSynchronously

    let siloPort, gatewayPort, primarySiloPort, dashboardPort, testsApiPort, clusterName, serviceName, prometheusAddress = portsAsync |> Async.RunSynchronously
    printfn $"Cluster Name: {clusterName}"
    printfn $"Service Name: {serviceName}"
    printfn $"IP Address: {ipAddress.ToString()}"
    printfn $"Silo Port: {siloPort}"
    printfn $"Gateway Port: {gatewayPort}"
    printfn $"Primary Silo Port: {primarySiloPort}"
    printfn $"Dashboard Port: {dashboardPort}"
    printfn $"Tests API Port: {testsApiPort}"

    let configureLogging (builder: ILoggingBuilder) =
        let filter (l: LogLevel) = l.Equals LogLevel.Information

        builder.AddFilter(filter).AddConsole().AddDebug()
        |> ignore

    let builder = HostBuilder()
    let configureServices = 
        builder.ConfigureServices(fun (services : IServiceCollection) ->
                services.AddSingleton<TestWebClientFixture>() |> ignore
                services.AddSingleton<TestCpuFixture>() |> ignore
                services.AddSingleton<TestIoFixture>() |> ignore
                services.AddSingleton<TestClassFixture>() |> ignore
                services.AddSingleton<ActivityTracer>() |> ignore
                services.AddOpenTelemetryTracing(fun (tracerBuilder : TracerProviderBuilder) ->
                    tracerBuilder.AddConsoleExporter(fun (config : ConsoleExporterOptions) ->
                            config.Targets <- ConsoleExporterOutputTargets.Console
                        ) |> ignore
                    tracerBuilder.AddSource("test_tracer") |> ignore
                    tracerBuilder.SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("SiloHost")) |> ignore
                    ) |> ignore
                services.AddOpenTelemetryMetrics(fun (meterBuilder : MeterProviderBuilder) ->
                    meterBuilder.AddPrometheusExporter(fun (options : PrometheusExporterOptions) ->
                        options.StartHttpListener <- true
                        options.HttpListenerPrefixes <- [prometheusAddress]
                        options.ScrapeResponseCacheDurationMilliseconds <- 0
                        ) |> ignore
                    meterBuilder.AddMeter("web_test_execution_meter") |> ignore
                    meterBuilder.AddMeter("cpu_test_execution_meter") |> ignore
                    meterBuilder.AddMeter("io_test_execution_meter") |> ignore
                    ) |> ignore
            )

    let siloConfiguration =
        fun (siloBuilder: ISiloBuilder) ->
            siloBuilder
                .UseDevelopmentClustering(fun (options: DevelopmentClusterMembershipOptions) ->
                    options.PrimarySiloEndpoint <- IPEndPoint(ipAddress, primarySiloPort))
                .Configure<GrainCollectionOptions>(fun (options: GrainCollectionOptions) ->
                    options.CollectionAge <- TimeSpan.FromSeconds(61.0))
                .Configure<ClusterOptions>(fun (options: ClusterOptions) ->
                    options.ClusterId <- clusterName
                    options.ServiceId <- serviceName)
                .Configure<EndpointOptions>(fun (options: EndpointOptions) ->
                    options.SiloPort <- siloPort
                    options.AdvertisedIPAddress <- ipAddress
                    options.GatewayPort <- gatewayPort
                    options.SiloListeningEndpoint <- IPEndPoint(IPAddress.Any, siloPort)
                    options.GatewayListeningEndpoint <- IPEndPoint(IPAddress.Any, gatewayPort))
                .Configure<MessagingOptions>(fun (options: MessagingOptions) ->
                    options.ResponseTimeout <- TimeSpan.FromSeconds(90))
                .UseDashboard(fun (options: DashboardOptions) ->
                    options.Username <- "piotr"
                    options.Password <- "orleans"
                    options.Port <- dashboardPort)
                .UseLinuxEnvironmentStatistics()
                .ConfigureApplicationParts(fun applicationPartManager ->
                    applicationPartManager
                        .AddApplicationPart(Assembly.GetAssembly(typeof<AsynchronousTests>))
                        .WithReferences()
                        .WithCodeGeneration()
                    |> ignore)
                .ConfigureLogging(configureLogging)
            |> ignore

    builder
        .ConfigureWebHostDefaults(fun (webHostBuilder) ->
            webHostBuilder
                .Configure(fun applicationBuilder ->
                    applicationBuilder
                        .UseRouting()
                        .UseEndpoints(fun endpoints -> endpoints.MapControllers() |> ignore)
                    |> ignore)
                .ConfigureServices(fun services -> services.AddControllers() |> ignore)
                .UseUrls($"http://*:{testsApiPort}")
            |> ignore)
        .UseOrleans(siloConfiguration)
        .RunConsoleAsync()
    |> Async.AwaitTask
    |> Async.RunSynchronously

    0
