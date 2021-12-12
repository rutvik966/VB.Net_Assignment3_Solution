Imports System.Console

Module Program
    Sub Main()

        Dim n, y, i As Integer

        Write("Enter Any Year : ")
        y = ReadLine()

        For n = 0 To y Step 4
            WriteLine(n)
        Next

        If n = i Then
            WriteLine(y & "Is Leap Year")
        End If

    End Sub
End Module