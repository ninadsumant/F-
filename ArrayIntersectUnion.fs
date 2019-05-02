open System
printfn "Enter the number of elements  in Array 1:"
let mutable n = int(Console.ReadLine())
let mutable arr1 = Array.create n 0
for i in 0 .. n-1 do 
    arr1.[i]<-int(Console.ReadLine())

printfn "Enter the number of elements in Array 2:"
let mutable m = int(Console.ReadLine())
let mutable arr2 = Array.create m 0
for i in 0 .. m-1 do 
    arr2.[i]<-int(Console.ReadLine())

printfn "Array is : %A" arr1
printfn "Array is : %A" arr2

printfn "Intersection of array is:"
let mutable c =set(arr1)-set(set(arr1)-set(arr2))
printfn "%A" c

printfn "Union of array is:"
let mutable u =set(arr1)+set(arr2)
printfn "%A" u
Console.Read()
