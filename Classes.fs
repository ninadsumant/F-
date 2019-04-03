open System
type Student( ) =
    class
    let mutable rno=0
    let mutable name=""
    member s.accept( )=
        printf "Enter the Roll Number\n"
        rno<-int(Console.ReadLine())
        printf "Enter the name\n"
        name<-Console.ReadLine()
    member s.display( )=
        printfn "Roll No is : %d" rno
        printfn "Name is : %s" name
    end

let obj = new Student( )
obj.accept( )
obj.display( )
Console.Read()


//WAP to accept empId, name and salary from user and initilize it using the constructor 
open System
type Employee(id, name, salary)=
    class
    let mutable empId = id
    let mutable empName = name
    let mutable empSalary = salary
    member e.display( )=
        printfn "Employee ID is : %d" empId
        printfn "Name is : %s" empName
        printfn "Name is : %d" empSalary
    end

let obj = new Employee(50,"Ninad",100000000)
obj.display( )
Console.Read()

open System
type Department( ) =
    class
    let mutable dname=""
    member d.accept( )=
        printf "Enter the department name\n"
        dname<-Console.ReadLine()
    member s.display( )=
        printfn "Departname Name is : %s" dname
    end
 type Emp( )=
    class
    inherit Department()
    let mutable name=""
    let mutable id=0
    member e.accept1( )=
        printfn "Enter ID:"
        id<-int(Console.ReadLine())
        printfn "Enter Name:"
        name<-Console.ReadLine()
    member e.display1( )=
        printfn "Employee ID is : %d" id
        printfn "Name is : %s" name
    end

let obj = new Emp( )
obj.accept( )
obj.display( )
obj.accept1( )
obj.display1( )
Console.Read()


open System
type Department(d) =
    class
    let mutable dname=d
    member s.display( )=
        printfn "Departname Name is : %s" dname
    end
 type Emp(d, n,Id)=
    class
    inherit Department(d)
    let mutable name=n
    let mutable id=Id
    member e.display1( )=
        printfn "Employee ID is : %d" id
        printfn "Name is : %s" name
    end

let obj = new Emp("Dev","Shrikar",80)
obj.display( )
obj.display1( )
Console.Read()

