module PrintSequence

let printSequence (sequence : 'T seq) = 
    sequence |> Seq.iter (fun item -> printf "%O " item);
    printfn ""