﻿
[<EntryPoint>]
let main _ =
    let euclidRes = SimpleAlgorithms.gcd 14159572  63967072
    let fibonacciRes = SimpleAlgorithms.fibonacci euclidRes
    SimpleAlgorithms.variousTerms 6 |> ignore
    0 
