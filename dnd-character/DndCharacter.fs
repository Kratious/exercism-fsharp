module DndCharacter

open System

type Character =
    { Strength: int
      Dexterity: int
      Constitution: int
      Intelligence: int
      Wisdom: int
      Charisma: int
      Hitpoints: int }

let modifier (x: int): int = (float (x - 10)) / 2.0 |> floor |> int

let ability (): int =
    let random = Random()

    List.init 4 (fun _ -> random.Next(1, 7))
    |> List.sort
    |> List.tail
    |> List.sum


let createCharacter (): Character =
    let constitution = ability ()

    { Strength = ability ()
      Dexterity = ability ()
      Constitution = constitution
      Intelligence = ability ()
      Wisdom = ability ()
      Charisma = ability ()
      Hitpoints = 10 + modifier constitution }
