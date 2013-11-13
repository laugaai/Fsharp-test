module Program

let numbers = [1 .. 10]
let square x = x * x
let squaredNumbers = List.map square numbers
printfn "SquaredNumbers = %A" squaredNumbers
open System
printfn "(press any key to continue)"

Console.ReadKey(true)
