// Program.fsx

// List of used numbers
let used = [8; 23; 9; 2; 12; 11; 10; 13; 7; 4; 21; 5; 17; 3; 19; 2; 6]

// Function to find the smallest missing non-negative integer
let smallestMissing (xs: int list) =
    let s = Set.ofList xs
    Seq.initInfinite id |> Seq.find (fun n -> not (s.Contains n))

// Lets try it out
let result = smallestMissing used
printfn "The smallest missing non-negative integer is: %d" result