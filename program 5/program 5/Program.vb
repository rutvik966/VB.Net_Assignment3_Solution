Imports System.Console

Module Program
    Sub Main()

        Dim i, n, j, s, a As Integer

        Write("Enter Value Do You Want Start Any Number : ")
        s = ReadLine()

        Write("Enter Value Do You Want End Any Number : ")
        a = ReadLine()

        n = a - s + 1
        WriteLine("Total Number Is " & n)

        For j = s To a
            i = j + i
        Next

        WriteLine("Sum Is " & i)
        WriteLine("Average IS " & i / n)

    End Sub
End Module