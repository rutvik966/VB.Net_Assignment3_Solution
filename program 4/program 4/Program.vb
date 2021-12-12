Imports System.Console

Module Program
    Sub Main()

        Dim i, n, j, s, a As Integer

        Write("Enter Value Do You Want Start Any Number : ")
        s = ReadLine()

        Write("Enter Value Do You Want End Any Number : ")
        a = ReadLine()

        For j = s To a
            i = j + i
        Next

        WriteLine("Sum Is " & i)

    End Sub
End Module