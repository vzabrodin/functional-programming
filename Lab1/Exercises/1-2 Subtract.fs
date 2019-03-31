module SubtractSequences

let subtract (source1 : int seq) (source2 : int seq) : int seq = 
    Seq.map2 (-) source1 source2

let testSubtract = 
    let sequence1 = GetRandomSequence.getRandomSequence 1 100 |> Seq.take 10 |> Seq.toArray
    let sequence2 = GetRandomSequence.getRandomSequence 1 100 |> Seq.take 10 |> Seq.toArray

    sequence1 |> PrintSequence.printSequence
    sequence2 |> PrintSequence.printSequence
    subtract sequence1 sequence2 |> PrintSequence.printSequence