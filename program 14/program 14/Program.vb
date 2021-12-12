Imports System.Console

Module Program
    Sub Main()

        Dim i, n, j, s, a As Integer

        WriteLine("Enter Any Number Upto Print Series : ")
        n = ReadLine()

        WriteLine("Series Is .........")

        For i = 1 To n

            s = i * i ' 2 * 2 = 4 
            j = i - 1 ' 2 - 1 = 1

            a = s - j ' 4 - 1 = 3

            WriteLine(a) ' 3
        Next



    End Sub
End Module