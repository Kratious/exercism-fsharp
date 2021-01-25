module Hamming

let distance (strand1: string) (strand2: string): int option =
    match strand1.Length <> strand2.Length with
    | true -> None
    | false -> Some(Seq.zip strand1 strand2 |> Seq.sumBy(fun (x,y) -> if x = y then 0 else 1))