// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
open System

[<EntryPoint>]
let main argv =
    printfn "Enter marks for four subjects (out of 100):"

    printf "Subject 1: "
    let m1 = int (Console.ReadLine())

    printf "Subject 2: "
    let m2 = int (Console.ReadLine())

    printf "Subject 3: "
    let m3 = int (Console.ReadLine())

    printf "Subject 4: "
    let m4 = int (Console.ReadLine())

    let total = m1 + m2 + m3 + m4
    let percentage = float total / 4.0

    let division =
        match percentage with
        | p when p >= 60.0 -> "First Division"
        | p when p >= 50.0 -> "Second Division"
        | p when p >= 40.0 -> "Third Division"
        | _ -> "Fail"

    printfn "\nTotal Marks: %d / 400" total
    printfn "Percentage: %.2f%%" percentage
    printfn "Division: %s" division

    0