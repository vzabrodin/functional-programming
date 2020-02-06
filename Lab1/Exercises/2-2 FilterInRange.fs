module FilterInRange

let filterInRange (min: int) (max: int) (sequence: int seq): int seq =
    sequence |> Seq.where (fun x -> x > min && x < max)

let testFilterInRange =
    let sequence =
        GetRandomSequence.getRandomSequence 1 20
        |> Seq.take 10
        |> Seq.toArray

    sequence |> PrintSequence.printSequence
    
    sequence
    |> filterInRange 10 100
    |> PrintSequence.printSequence
