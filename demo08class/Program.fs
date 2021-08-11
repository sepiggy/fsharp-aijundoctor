type MyClass1(name: string, age: int, salary: float) =
    let name2 = name + "hahaha"
    do printfn "creating MyClass 1"
    member val name = name with get, set
    member val age = age with get, set
    member val salary = salary with get, set
    member this.Name = name2

type MyClass2(name: string, age: int, salary: float, gender: int) =
    inherit MyClass1(name, age, salary)
    let g = gender
    do 
        printfn "creating MyClass 2"
        printfn "hahaha"
    member val gender = gender with get, set
    member this.Gender = g

let t1 = MyClass1("testl", 1, 1.0)
let t2 = MyClass2("test2", 2, 2.0, 1)
// let t3 = t1 :> MyClass2
let t4 = t2 :> MyClass1

t4.name
t4.name <- "test4"
let t5 = t4 :?> MyClass2
t5.name
t5.Gender
