namespace Grains

open System
open System.Diagnostics
open System.Diagnostics.Metrics
open System.Net.Http
open System.Threading.Tasks
open Library.TestInterfaces
open Orleans
open Xunit

type TestWebClientFixture() =
    let meter = new Meter("web_test_execution_meter")
    let counter = meter.CreateCounter<int>("web_test_number", "Tests")
    let histogram = meter.CreateHistogram<int64>("web_test_response", "ms")
    
    let client = new HttpClient()
    member this.GetResponseString(endpoint : string) : Task<string> =
        task{
            let watch = Stopwatch.StartNew()
            let! response = client.GetAsync(endpoint) |> Async.AwaitTask
            response.EnsureSuccessStatusCode () |> ignore
            let! content = response.Content.ReadAsStringAsync() |> Async.AwaitTask
            watch.Stop()

            histogram.Record(watch.ElapsedMilliseconds)
            counter.Add(1)
            
            return content
        }

type DemoWebTests(httpClient : TestWebClientFixture) =
    inherit Grain()
    
    interface IDemoWebTests with
    
        [<Fact>]
        member this.WebTest1() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest2() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest3() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest4() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
        
        [<Fact>]
        member this.WebTest5() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest6() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest7() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest8() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest9() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest10() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest11() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest12() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest13() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest14() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest15() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest16() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest17() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest18() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest19() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest20() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest21() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest22() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest23() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest24() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
        
        [<Fact>]
        member this.WebTest25() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest26() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest27() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest28() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest29() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest30() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest31() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest32() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest33() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest34() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest35() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest36() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest37() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest38() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest39() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest40() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest41() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest42() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest43() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest44() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
        
        [<Fact>]
        member this.WebTest45() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest46() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest47() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest48() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest49() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest50() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest51() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest52() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest53() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest54() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest55() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest56() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest57() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest58() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest59() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest60() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest61() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest62() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest63() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest64() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
        
        [<Fact>]
        member this.WebTest65() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest66() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest67() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest68() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest69() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest70() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest71() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest72() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest73() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest74() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest75() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest76() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest77() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest78() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest79() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest80() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest81() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest82() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest83() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest84() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
        
        [<Fact>]
        member this.WebTest85() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest86() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest87() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest88() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest89() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest90() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest91() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest92() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest93() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest94() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest95() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest96() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest97() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest98() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }

        [<Fact>]
        member this.WebTest99() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            
        [<Fact>]
        member this.WebTest100() : Task =
            task {
                let! content = httpClient.GetResponseString("https://www.irishtimes.com/") |> Async.AwaitTask
                Assert.False(String.IsNullOrEmpty(content))
            }
            