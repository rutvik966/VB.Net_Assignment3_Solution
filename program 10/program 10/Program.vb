Imports System.Console

Module Program
    Sub Main()
        Dim n, r, t, s As Integer
        Dim s As Integer = 0

        Write("Enter the Number: ")
        n = ReadLine()

        t = n

        While n > 0
            r = n Mod 10
            s = (s * 10) + r
            n = n / 10
        End While

        If t = s Then
            Write("Number is Palindrome.")
        Else
            Write("Number is not Palindrome")
        End If

    End Sub
End Module