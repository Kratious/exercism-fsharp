module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int =
    numbers
    |> Seq.filter(fun x -> x > 0)
    |> Seq.collect(fun mult -> [mult .. mult .. upperBound - 1])
    |> Seq.distinct
    |> Seq.sum