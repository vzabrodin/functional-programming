[<EntryPoint>]
let main _: int =
    printfn "# MakeItTwice"
    MakeItTwice.testTwiceSeq
    printfn ""

    printfn "# SubtractSequences"
    SubtractSequences.testSubtract
    printfn ""

    printfn "# FilterOutEvenNumbers"
    FilterOutEvenNumbers.testFilterOutEvenNumbers
    printfn ""

    printfn "# FilterInRange"
    FilterInRange.testFilterInRange
    printfn ""

    printfn "# SqrtOfSumOfSquares"
    SqrtOfSumOfSquares.testSqrtOfSumOfSquares
    printfn ""

    printfn "# OrderBySinus"
    OrderBySinus.testOrderBySinus
    printfn ""

    printfn "# OrderByLengthOfListDescending"
    OrderByLengthOfListDescending.testOrderByLengthOfListDescending
    printfn ""

    printfn "# KeepMatchingItems"
    KeepMatchingItems.testCustomWhere
    printfn ""

    printfn "# CustomMap"
    CustomMap.testCustomMap
    printfn ""

    printfn "# OrderByLastTwoDigits"
    OrderByLastTwoDigits.testOrderByLastTwoDigits
    printfn ""

    0
