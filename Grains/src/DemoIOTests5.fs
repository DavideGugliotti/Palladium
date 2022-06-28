namespace Grains

open System
open System.IO
open System.Threading.Tasks
open Library.TestInterfaces
open Orleans
open Xunit

type DemoIOTests5 (ioFixture : TestIoFixture) =
    inherit Grain()
    
    interface IDemoIoTests5 with
    
        [<Fact>]
        member this.IoTest1() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest2() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest3() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest4() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest5() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest6() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest7() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest8() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest9() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest10() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest11() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest12() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest13() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest14() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest15() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest16() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest17() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest18() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest19() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest20() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest21() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest22() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest23() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest24() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest25() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest26() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest27() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest28() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest29() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest30() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest31() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest32() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest33() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest34() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest35() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest36() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest37() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest38() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest39() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest40() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest41() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest42() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest43() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest44() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest45() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest46() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest47() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest48() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest49() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest50() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest51() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest52() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest53() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest54() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest55() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest56() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest57() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest58() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest59() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest60() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest61() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest62() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest63() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest64() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest65() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest66() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest67() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest68() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest69() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest70() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest71() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest72() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest73() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest74() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest75() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest76() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest77() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest78() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest79() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest80() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest81() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest82() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest83() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest84() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest85() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest86() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest87() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest88() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest89() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest90() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest91() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest92() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest93() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest94() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest95() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest96() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest97() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest98() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest99() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
        
        [<Fact>]
        member this.IoTest100() : Task =
            task {
                let filePath = $"test{Guid.NewGuid()}.txt"
                File.WriteAllText(filePath, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.")
                
                let content = File.ReadAllText(filePath)
                File.Delete(filePath)
                
                Assert.True(content.StartsWith("Lorem ipsum"))
                ioFixture.CountTest() |> ignore
                
            }
