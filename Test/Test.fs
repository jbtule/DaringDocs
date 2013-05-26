
namespace Test
open System
open NUnit.Framework
open FsUnit

[<TestFixture>] 
type ``Doc Test`` ()=
                   
    [<Test>] member test.``Test`` ()=
                   "hello" |> should equal "Hello"
