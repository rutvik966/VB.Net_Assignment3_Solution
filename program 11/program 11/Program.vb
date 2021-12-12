Imports System.Console

Module Program
    Sub Main()

        Dim i, n, j As Integer

        WriteLine("Enter Any Number : ")
        n = ReadLine()

        For i = 1 To n
            j = n Mod 2
        Next

        Select Case j
            Case 1
                WriteLine("Prime Number")
            Case 0
                WriteLine("Not Prime Number")
        End Select

    End Sub
End Module