module GetRandomSequence

let private random = System.Random()

let getRandomSequence (min: int) (max: int): int seq =
    Seq.initInfinite (fun _ -> random.Next(min, max))

let getRandomSequenceFloat (min: float) (max: float): float seq =
    Seq.initInfinite (fun _ -> random.NextDouble() * (max - min) + min)
