type Gender =
    | Male
    | Female

type User =
    { Name: string
      Age: int
      Salary: float
      Gender: Gender }

let testGender = Male
let testGender2 = Gender.Female

let user =
    { Name = "jms"
      Age = 200
      Salary = 999999999.9
      Gender = Male }

let gender = user.Gender

type PlayerRecord =
    { Name: string
      Level: int
      Strenth: int
      Wisdom: int
      Exp: float }

type MonsterRecord = { Blood: float; Attack: int }

type NpcRecord = { Name: string; Line: string }

type Person =
    | PlayerCase of PlayerRecord
    | MonsterCase of MonsterRecord
    | NpcCase of NpcRecord
    | Animal of int
    | Dead

let npc = { Name = "npc1"; Line = "hello!" }
let p1 = NpcCase npc

let monster = { Blood = 10.0; Attack = 1 }
let p2 = Person.MonsterCase monster

let people = [ p1; p2 ]
