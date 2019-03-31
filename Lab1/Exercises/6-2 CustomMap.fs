module CustomMap

let rec customMap (selector : 'T -> 'U) (sequence : 'T list) =
    match sequence with
    | [] -> []
    | head::tail -> (selector head) :: (customMap selector tail)

let testCustomMap =
    let sequence = GetRandomSequence.getRandomSequence 0 100 |> Seq.take 10 |> Seq.toList

    sequence |> PrintSequence.printSequence
    sequence |> customMap (fun i -> i * 2) |> PrintSequence.printSequence