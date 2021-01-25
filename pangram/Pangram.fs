module Pangram

let isPangram (input: string): bool = 
    (Set.difference (set['a'..'z']) (set(input.ToLower()))).IsEmpty
