Imports System.Math
Module Module1
    Public op, ans, num1, num2 As Integer

    Sub menu()
start:

        Console.WriteLine("#########################################")
        Console.WriteLine("#    1) add                             #")
        Console.WriteLine("#    2) subtract                        #")
        Console.WriteLine("#    3) multiply                        #")
        Console.WriteLine("#    4) divide                          #")
        Console.WriteLine("#    5) power                           #")
        Console.WriteLine("#    6) square                          #")
        Console.WriteLine("#    7) square root                     #")
        Console.WriteLine("#########################################")
        Try
            op = Console.ReadLine
            If op > 7 Then

                MsgBox("the number you entered is too high. Please enter 1-7!", MsgBoxStyle.Critical, "error")
                Console.Clear()
                GoTo start
            End If
        Catch ex As Exception
            MsgBox("error. do not enter a letter!", MsgBoxStyle.Critical, "error"
            Console.Clear()
            GoTo start

        End Try
    End Sub
    Sub Main()
        menu()
        Select Case op
            Case 1
                ans = num1 + num2
            Case 2

            Case 3

            Case 4

            Case 4

            Case 5

            Case 6

            Case 7

            Case Else

        End Select

    End Sub

End Module
