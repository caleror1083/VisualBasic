'Robert Calero
'Math Operators VB-Console Application

Module Module1

    Sub Main()
        Console.WriteLine("Math Operators Examples") 'Writes text to the console
        Console.WriteLine(" ") 'Writes text to the console

        Dim num As Integer 'Variable declaration
        Dim num1 As Integer 'Variable declaration
        Dim num2 As Integer 'Variable declaration
        Dim num3 As Integer 'Variable declaration
        Dim num4 As Integer 'Variable declaration
        Dim num5 As Integer 'Variable declaration
        Dim num6 As Integer = 100 'Declare and assign a value to the variable
        Dim num7 As Integer = 2 'Declare and assign a value to the variable
        Dim total As Double = Nothing 'Declare and assign a null value to the variable
        Dim myInt As Integer = 50 'Declare and assign a value to the variable

        num = 5 + 5 'Addition - Assigns a value to the variable
        num1 = 5 - 5 'Subtraction - Assigns a value to the variable
        num2 = 5 * 5 'Multiplication - Assigns a value to the variable
        num3 = 5 / 5 'Division - Assigns a value to the variable
        num4 = 39 Mod 4 'Modulus Division, outputs remainder
        num5 = 5 ^ 3 'Exponents
        total = num6 / num7 'Divides 2 variables and assigns the value to another variable
        'myInt = myInt + 23 'Adds a value to a variable
        myInt += 23 'alternate way to add a value to a variable

        Console.WriteLine(num) 'Writes the variable value to the console
        Console.WriteLine(num + 5) 'Writes the variable value to the console
        Console.WriteLine(num1) 'Writes the variable value to the console
        Console.WriteLine(num2) 'Writes the variable value to the console
        Console.WriteLine(num3) 'Writes the variable value to the console
        Console.WriteLine(num4) 'Writes the variable value to the console
        Console.WriteLine(num5) 'Writes the variable value to the console
        Console.WriteLine(num6 + num7) 'Writes the variable value to the console
        Console.WriteLine(total) 'Writes the variable value to the console
        Console.WriteLine(myInt) 'Writes the variable value to the console
        Console.WriteLine("Initial Value: 11 : New Value: " & myInt) 'Writes the variable value to the console and concatenates a string

        Console.ReadLine() 'This pauses the program
    End Sub

End Module