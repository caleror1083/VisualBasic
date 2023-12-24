'Robert Calero
' Variables VB-Console Application

Module Module1

    Sub Main()
        Console.WriteLine("Variable Examples") 'Writes text to the console
        Console.WriteLine(" ") 'Writes text to the console

        'Dim num As Integer 'Variable declaration
        'num = 5 'Assigns a value to the variable

        'Numbers-Integers
        Dim myByte As Byte = 1 'Declare and assign a value to the variable
        Dim myShort As Short = 2 'Declare and assign a value to the variable
        Dim mynum As Integer = 5 'Declare and assign a value to the variable
        Dim myLong As Long = 3 'Declare and assign a value to the variable

        'Numbers-Real Numbers
        Dim numDouble As Double = 5.9 'Declare and assign a value to the variable
        Dim myFloat As Decimal = 4.5 'Declare and assign a value to the variable

        'Characters
        Dim myString As String = "Hello!" 'Declare and assign a string to the variable
        Dim myChar As Char = "A" 'Declare and assign a character to the variable

        'Logical
        Dim myBool As Boolean = True 'Declare and assign a logical value to the variable

        Console.WriteLine(myByte) 'Writes the variable value to the console
        Console.WriteLine(myShort) 'Writes the variable value to the console
        Console.WriteLine(mynum) 'Writes the variable value to the console
        Console.WriteLine(mynum.ToString()) 'Converts an integer to a String
        Console.WriteLine(myLong) 'Writes the variable value to the console
        Console.WriteLine(numDouble) 'Writes the variable value to the console
        Console.WriteLine(myFloat) 'Writes the variable value to the console
        Console.WriteLine(myString) 'Writes the variable value to the console
        Console.WriteLine(myChar) 'Writes the variable value to the console
        Console.WriteLine(myBool) 'Writes the variable value to the console
        Console.ReadLine() 'This pauses the program
    End Sub

End Module