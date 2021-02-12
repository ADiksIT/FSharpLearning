module SimpleAlgorithms

let fibonacci n =
    let mutable a, b, res = 0, 1, 0
    for i in 2 .. n do
        res <- (a + b)
        a <- b
        b <- res
    res
    
let gcd x y =
    let rec euclid a b =
        match a, b with
        | 0, _ -> b
        | _, 0 -> a
        | a, b when a >= b -> euclid (a % b) b
        | _ -> euclid a (b % a)
    euclid x y