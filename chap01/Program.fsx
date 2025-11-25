// Program.fsx

// List of used numbers
let used = [8; 23; 9; 2; 12; 11; 10; 13; 7; 4; 21; 5; 17; 3; 19; 2; 6]

// Function to find the smallest missing non-negative integer
// let smallestMissing (xs: int list) =
//     let s = Set.ofList xs
//     Seq.initInfinite id |> Seq.find (fun n -> not (s.Contains n))


// Prepara la lista: elimina duplicados y ordena
let prepare xs = xs |> List.distinct |> List.sort

// Algoritmo divide y vencerás
let rec smallestMissing (xs: int list) low high =
    if low > high then low
    else
        let mid = (low + high) / 2
        if xs.[mid] = mid then
            smallestMissing xs (mid + 1) high
        else
            smallestMissing xs low (mid - 1)

// Función principal
let findMissing xs =
    let clean = prepare xs
    smallestMissing clean 0 (List.length clean - 1)



// Lets try it out
// let result = smallestMissing used

let result = findMissing used

printfn "The smallest missing non-negative integer is: %d" result