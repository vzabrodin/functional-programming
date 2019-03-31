module OrderByLastTwoDigits

let orderByLastTwoDigits sequence =
    Seq.sortWith
        (fun x y -> compare (x % 100) (y % 100))
        sequence

let testOrderByLastTwoDigits =
    let sequence = GetRandomSequence.getRandomSequence 1000 9999 |> Seq.take 10 |> Seq.toArray

    sequence |> PrintSequence.printSequence
    sequence |> orderByLastTwoDigits |> PrintSequence.printSequence