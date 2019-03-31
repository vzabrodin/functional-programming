module GetRandomSequence

let getRandomSequence (min : int) (max : int) : int seq =
    let random = System.Random()
    Seq.initInfinite (fun _ -> random.Next(min, max))

let getRandomSequenceFloat (min : float) (max : float) : float seq =
    let random = System.Random()
    Seq.initInfinite (fun _ -> random.NextDouble() * (max - min) + min)