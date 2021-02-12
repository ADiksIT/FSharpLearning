let fibonacci n =
    let mutable a = 1
    let mutable b = 1
    let mutable res = 0
    for i = 2 to n - 1 do
        res <- (a + b)
        a <- b
        b <- res
    res
    
let gcd x y =
    let rec euclid a b =
        if a = 0 then b
        elif b = 0 then a
        elif a >= b then euclid (a % b) b
        else euclid a (b % a)
    euclid x y

[<EntryPoint>]
let main _ =
    let euclidRes = gcd 14159572  63967072
    let fibonacciRes = fibonacci euclidRes
    printfn "%A" fibonacciRes
    0 
