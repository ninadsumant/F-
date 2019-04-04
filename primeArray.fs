
//WAP to accept n elmts from user and store prime number in primeArray and Perfect in perfectArray and display Both arrays

open System
let mutable k=0
let mutable p=0

printfn "Enter the value of N :"
let mutable n = int(Console.ReadLine())
let mutable primeArray = Array.create n 0
let mutable perfectArray = Array.create n 0 
let mutable array = Array.create n 0
for i in 0 .. n-1 do
    array.[i]<-int(Console.ReadLine())

for i in 0 .. array.Length-1 do
    let mutable flag = false
    let mutable m = array.[i]
    for j=2 to m/2 do
        if m%j = 0 then
            flag <- true
    if flag<> true then
        primeArray.[k]<-m
        k<-k+1


for i in 0 .. array.Length-1 do
    let mutable sum =0
    let mutable num = array.[i]
    for j=1 to num-1 do
        if num%j = 0 then
            sum <- sum+j
    if sum=num then
        perfectArray.[p]<-num 
        p<-p+1
printfn "Prime Number Array:"
for i in 0 .. k-1 do
    printfn "%d " primeArray.[i]

printfn "Perfect Number Array:"
for i in 0 .. p-1 do
    printfn "%d " perfectArray.[i]

Console.Read()


  
