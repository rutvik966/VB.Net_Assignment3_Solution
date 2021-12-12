Imports System.Console

Module Program
    Sub Main()

        Dim i, n As Integer

        WriteLine("Enter Any Number Upto Print Series : ")
        n = ReadLine()

        WriteLine("Series Is .........")

        For i = 1 To n
            WriteLine(i * i * i) ' 2*2*2 = 4 ......
        Next

    End Sub
End Module