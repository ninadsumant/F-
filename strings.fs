open System
let mutable str = Console.ReadLine()
let mutable length = str.Length
printfn "Length of String is : %i" length


printfn "Reverse of string is:"
for i=length-1 downto 0  do
    printf "%c" str.[i]
printfn ""

printfn "Alternate characters of string are:"
for i in 0 ..2.. length-1  do
    printf "%c" str.[i]

Console.Read()
