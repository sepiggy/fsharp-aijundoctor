let a = 10
let mutable b = 10
a = 10
b = 20
// a <- 100
b <- 100

type NPCRecord = { Name: string; mutable Line: string }

let npc = { Name = "npc1"; Line = "!" }

npc.Line <- "test"
