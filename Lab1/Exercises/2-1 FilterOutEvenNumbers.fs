module FilterOutEvenNumbers

let filterOutEvenNumbers (sequence : int seq) : int seq =
    sequence |> Seq.where (fun x -> x % 2 <> 1)

let testFilterOutEvenNumbers =
    let sequence = GetRandomSequence.getRandomSequence 1 100 |> Seq.take 10 |> Seq.toArray

    sequence |> PrintSequence.printSequence
    sequence |> filterOutEvenNumbers |> PrintSequence.printSequence