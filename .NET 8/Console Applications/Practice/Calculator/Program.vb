'Calculator - Visual Basic Console Application
Imports System

Friend Module Program
    Public Sub Main()
        Dim number1 As Integer
        Dim number2 As Integer
        Dim product As Integer

        Console.Write("Enter the first number: ")
        number1 = Console.ReadLine()

        Console.Write("Enter the second number: ")
        number2 = Console.ReadLine()

        product = number1 * number2

        Console.Write("The answer is: " & product)
        Console.ReadKey()
    End Sub
End Module