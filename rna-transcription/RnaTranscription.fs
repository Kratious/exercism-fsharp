module RnaTranscription

let toRna (dna: string): string =
    dna
    |> Seq.map
        (fun nucl ->
            match nucl with
            | 'G' -> 'C'
            | 'C' -> 'G'
            | 'T' -> 'A'
            | 'A' -> 'U'
            | _ -> failwith "invalid")
    |> System.String.Concat
