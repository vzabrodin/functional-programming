module OrderByLengthOfListDescending

let random = System.Random()

let orderByLengthOfListDescending (sequence : 'T seq seq) : 'T seq seq =
    sequence |> Seq.sortByDescending (fun item -> item |> Seq.length)

let testOrderByLengthOfListDescending = 
    let arrayOfArrays =
        Seq.init 10 (fun i ->
                GetRandomSequence.getRandomSequence 0 100
                    |> Seq.take (random.Next(1, 10))
                    |> Seq.toArray
                    |> Seq.ofArray)
            |> Seq.toArray

    arrayOfArrays
        |> Seq.iter (fun item -> item |> PrintSequence.printSequence)

    printfn ""

    arrayOfArrays
        |> orderByLengthOfListDescending
        |> Seq.iter (fun item -> item |> PrintSequence.printSequence)