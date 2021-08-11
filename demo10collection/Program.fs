let list123 = [ 1; 2; 3 ]
let list1 = [ 1 .. 2 .. 10 ]
let emptyList = []
let list2 = 100 :: list1
let list3 = list1 @ list2
printfn "%A" list3.[0]
// list3.[0] <- 123

let array1 = [| 1; 2; 3 |]
array1.[0] <- 123

let arrayOfTenZeros: int array = Array.zeroCreate 10
let array2 = [| 1 .. 10 |]
array2.[0..2]
array1.[..2]
array2.[2..]

let matrix = Array2D.zeroCreate<int> 3 3
matrix.[1.., *]
matrix.[*, 1..2]

seq { 0 .. 10 .. 100 }

let seqFromArray1 = [| 1 .. 10 |] :> seq<int>
let seqFromArray2 = [| 1 .. 10 |] |> Seq.ofArray
