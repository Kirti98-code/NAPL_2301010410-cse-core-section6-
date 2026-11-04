// List.map
let numbers1 = [1; 2; 3; 4; 5]
let squares1 = List.map (fun x -> x * x) numbers1

let numbers2 = [2; 4; 6; 8]
let squares2 = List.map (fun x -> x * x) numbers2

printfn "List.map - Squares:"
printfn "%A" squares1
printfn "%A" squares2

// List.filter
let list1 = [1; 2; 3; 4; 5; 6]
let even1 = List.filter (fun x -> x % 2 = 0) list1

let list2 = [10; 11; 12; 13; 14]
let even2 = List.filter (fun x -> x % 2 = 0) list2

printfn "\nList.filter - Even Numbers:"
printfn "%A" even1
printfn "%A" even2

// List.fold
let values1 = [1; 2; 3; 4; 5]
let sum1 = List.fold (fun acc x -> acc + x) 0 values1

let values2 = [10; 20; 30; 40]
let sum2 = List.fold (fun acc x -> acc + x) 0 values2

printfn "\nList.fold - Sum:"
printfn "%d" sum1
printfn "%d" sum2