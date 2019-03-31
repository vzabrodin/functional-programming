module OrderBySinus

let orderBySinus (sequence : float seq) : float seq =
    sequence |> Seq.sortBy sin

let testOrderBySinus =
    let sequence = GetRandomSequence.getRandomSequenceFloat 0. 10. |> Seq.take 10 |> Seq.toArray

    sequence |> PrintSequence.printSequence
    sequence |> orderBySinus |> PrintSequence.printSequence