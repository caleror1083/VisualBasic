'Robert Calero
'User Input VB-Console Application

Module Module1

    Sub Main()
        Console.WriteLine("User Input Examples") 'Writes text to the console
        Console.WriteLine(" ") 'Writes a blank line to the console

        Dim userName As String = Nothing 'Declare and assign a null value to the variable
        Dim userAge As Integer = Nothing 'Declare and assign a null value to the variable
        Dim userSalary As Double = Nothing 'Declare and assign a null value to the variable

        Console.Write("What is your name? ") 'Writes the string to the console and stays on the same line
        userName = Console.ReadLine() 'gets input from the user and

        Console.Write("What is your age? ") 'Writes the string to the console and stays on the same line
        userAge = Console.ReadLine() 'gets input from the user

        Console.Write("What is your salary? ") 'Writes the string to the console and stays on the same line
        userSalary = Console.ReadLine() 'gets input from the user

        Console.WriteLine(" ") 'Writes a blank line to the console

        Console.WriteLine("Your name is: " & userName) 'Displays the input from the user to the console 
        Console.WriteLine("Your age is: " & userAge) 'Displays the input from the user to the console 
        Console.WriteLine("Your salary is: " & userSalary) 'Displays the input from the user to the console 

        Console.ReadLine() 'This pauses the program
    End Sub

End Module