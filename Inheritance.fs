open System
type College()=
    class
    let mutable cid = 0
    let mutable cname =""
    member c.accept()=
        printfn "Enter the College ID:"
        cid<- int(Console.ReadLine())
        printfn "Enter The college name:"
        cname <- Console.ReadLine()
    member c.display()=
        printfn "College ID is : %d" cid
        printfn "College name is : %s" cname
    end
type Student()=
    class
    inherit College()
    let mutable rno = 0
    let mutable name = ""
    let mutable age =0
    member s.accept1()=
        base.accept()
        printfn "Enter the Student ID:"
        rno<- int(Console.ReadLine())
        printfn "Enter the Student Age:"
        age<- int(Console.ReadLine())
        printfn "Enter the Student Name:"
        name<- Console.ReadLine()
    member s.display1()=
        base.display()
        printfn "Student Roll No is %d" rno
        printfn "Student Name No is %s" name
        printfn "Student age is %d" age
    end
type Result()=
    class
    inherit Student()
    let mutable f=0
    let mutable R=0
    member r.acc()=
        base.accept1()
        printfn"Enter marks"
        f<- int(Console.ReadLine())
        R<- int(Console.ReadLine())
    member r.disp()=
        base.display1()
        printfn"marks: "
        printfn"F#: %d" f
        printfn"R : %d" R
    end
let obj=new Result()
obj.acc()
obj.disp()


Console.Read()
