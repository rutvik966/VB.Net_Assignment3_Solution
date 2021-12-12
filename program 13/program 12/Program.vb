Imports System.Console

Module Program
    Sub Main()

        Dim i, n, j, s, a As Integer

        WriteLine("Enter Any Number Upto Print Series : ")
        n = ReadLine()

        WriteLine("Series Is .........")

        j = 1

        For i = 1 To n
            j = j * 3
            WriteLine(j)
        Next

    End Sub
End Module