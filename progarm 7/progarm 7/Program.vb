Imports System.Console

Module Program
    Sub Main()

        Dim s, a As Integer

        Write("Enter Value Do You Want Upto Table Number : ")
        s = ReadLine()

        Write("Enter Value Do You Want Show Table : ")
        a = ReadLine()

        For s = 1 To s
            Write(a & " * " & s & " = ")
            WriteLine(s * a)
        Next

    End Sub
End Module