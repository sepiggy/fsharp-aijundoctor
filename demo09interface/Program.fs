type IPrintable =
    abstract member Print : unit

type SomeClass1(x: int, y: float) =
    interface IPrintable with
        member this.Print = printfn "%d %f" x y

type Interface1 =
    abstract member Method1 : int

type Interface2 =
    abstract member Method2 : int

type Interface3 =
    inherit Interface1
    inherit Interface2
    abstract member Method3 : int

type MyClass(n) =
    interface Interface3 with
        member this.Method1 = 2 * n
        member this.Method2 = n + 100
        member this.Method3 = n / 10

let x1 = new SomeClass1(1, 2.0)
(x1 :> IPrintable).Print
