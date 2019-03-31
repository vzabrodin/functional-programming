module SqrtOfSumOfSquares

let sqrtOfSumOfSquares (sequence : float seq) : float =
    sequence
    |> Seq.map (fun x -> x * x)
    |> Seq.reduce (+)
    |> sqrt

let sqrtOfSumOfSquares2 (sequence : float seq) : float =
    sequence
    |> Seq.sumBy (fun x -> x * x)
    |> sqrt

let testSqrtOfSumOfSquares = 
    let sequence = GetRandomSequence.getRandomSequenceFloat 0. 100. |> Seq.take 10 |> Seq.toArray

    sequence |> PrintSequence.printSequence
    sequence |> sqrtOfSumOfSquares |> printfn "%f"
    sequence |> sqrtOfSumOfSquares2 |> printfn "%f"