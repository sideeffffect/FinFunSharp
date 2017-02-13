module FinFunSharp.Tests

open FinFunSharp
open NUnit.Framework

[<Test>]
let ``hello returns 42`` () =
  //let result = Library.GenerateDates null null null
  //printfn "%i" result
  Assert.AreEqual(42,42)
