// LAB 7 - QUESTION 1
// Asynchronous and Parallel Workflows in F#

let task1 =
    async {
        printfn "Task 1 Started"
        do! Async.Sleep 3000
        printfn "Task 1 Completed"
        return "Result of Task 1"
    }

let task2 =
    async {
        printfn "Task 2 Started"
        do! Async.Sleep 2000
        printfn "Task 2 Completed"
        return "Result of Task 2"
    }

let task3 =
    async {
        printfn "Task 3 Started"
        do! Async.Sleep 1000
        printfn "Task 3 Completed"
        return "Result of Task 3"
    }

let tasks = [task1; task2; task3]

printfn "Starting Parallel Execution..."

let results = Async.RunSynchronously (Async.Parallel tasks)

printfn "\nAll Tasks Completed!"
printfn "Collected Results:"

results |> Array.iter (printfn "%s")