Imports System.Console

Module Program
    Sub Main()

        Dim i, n, j As Integer

        Write("Enter Value Do You Want To Print Any Number : ")
        n = ReadLine()

        For j = 1 To n
            i = j + i
        Next

        WriteLine("Sum Is " & i)

    End Sub
End Module