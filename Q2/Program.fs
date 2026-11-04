
open System

let isPrime n =
    let rec check divisor =
        if divisor * divisor > n then
            true
        elif n % divisor = 0 then
            false
        else
            check (divisor + 1)

    if n <= 1 then
        false
    else
        check 2

[<EntryPoint>]
let main argv =
    printf "Enter a number: "
    let number = int (Console.ReadLine())

    if isPrime number then
        printfn "%d is a prime number." number
    else
        printfn "%d is not a prime number." number

    0
