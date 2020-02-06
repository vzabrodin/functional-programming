module MakeItTwice

let private twice (action: 'T -> unit) (item: 'T) =
    action item
    action item

let twiceSeq (action: 'T -> unit) (sequence: 'T seq) =
    sequence |> Seq.iter (fun item -> twice action item)

let testTwiceSeq =
    let sequence =
        GetRandomSequence.getRandomSequence 0 100
        |> Seq.take 10
        |> Seq.toArray

    sequence |> PrintSequence.printSequence
    sequence |> twiceSeq (fun x -> printf "%d " x)
    printfn ""
