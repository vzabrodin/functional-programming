module KeepMatchingItems

let customWhere (predicate: 'T -> bool) (sequence: 'T list) =
    let rec customWhereRecursive (sequence: 'T list) (sequence': 'T list) =
        match sequence with
        | [] -> sequence'
        | head :: tail ->
            if (predicate head) <> true then customWhereRecursive tail (sequence')
            else customWhereRecursive tail (sequence' @ [ head ])
    customWhereRecursive sequence []

let testCustomWhere =
    let sequence =
        GetRandomSequence.getRandomSequence 0 100
        |> Seq.take 10
        |> Seq.toList

    sequence |> PrintSequence.printSequence

    sequence
    |> customWhere (fun i -> i < 50)
    |> PrintSequence.printSequence
