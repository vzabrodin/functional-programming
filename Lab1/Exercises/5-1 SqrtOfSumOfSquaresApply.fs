module SqrtOfSumOfSquaresApply

(* there is no standart implementation for apply in F# *)
let apply (mapping: 'T -> 'U) (source: 'T seq) : ('T * 'U) seq =
    source |> Seq.map (fun x -> (x, mapping x))