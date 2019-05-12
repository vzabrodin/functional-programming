module OrderByLastTwoDigits

let orderByLastTwoDigits sequence =
    sequence |> Seq.sortWith (fun x y -> compare (x % 100) (y % 100))
    //sequence |> Seq.sortBy (fun x -> (x % 100))

let testOrderByLastTwoDigits =
    let sequence = GetRandomSequence.getRandomSequence 1000 9999 |> Seq.take 10 |> Seq.toArray

    sequence |> PrintSequence.printSequence
    sequence |> orderByLastTwoDigits |> PrintSequence.printSequence