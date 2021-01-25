module Isogram

let isIsogram (str:string) = 
    let justLetters = Seq.filter (fun char -> System.Char.IsLetter(char))  (str.ToLower())
    let distinctLetters = justLetters |> Seq.distinct
    
    Seq.length justLetters = Seq.length distinctLetters