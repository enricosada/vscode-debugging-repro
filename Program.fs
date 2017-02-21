// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let name = "Enrico"
    let l = [1;2;3]
    printfn "Hello World from F#!"
    failwith "oh no!"
    0 // return an integer exit code
