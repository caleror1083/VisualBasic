Imports System

Public Class Examples
    Public Shared Sub ProcessExamples()
        Start:
            Console.Write("Please select an example from 1-15: ")
            Dim input As String = Console.ReadLine()
            Dim check As Boolean = Integer.TryParse(input, 1)
            Dim choice As Integer = If(check, 1, 0)

            If check Then
                Select Case choice
                    Case 1
                        Example1()
                    Case Else
                        Console.WriteLine("Your choice is invalid")
                        GoTo Start
                End Select
            Else
                Console.WriteLine("Selection chosen is incorrect")
                GoTo Start
            End If
        Decide:
            Console.Write("Do you want to do another example? - Yes or No: ")
            Dim decision As String = Console.ReadLine()
            Console.WriteLine()

            Select Case decision.ToUpper()
                Case "YES"
                    GoTo Start
                Case "NO"
                    Exit Sub
                Case Else
                    Console.WriteLine("Your decision is invalid. Try again")
                    GoTo Decide
            End Select
    End Sub

    Private Shared Sub Example1()
        Console.WriteLine("Writes a string to the console")
    End Sub
End Class