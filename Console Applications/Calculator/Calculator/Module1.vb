'Robert Calero
'Calculator VB-Console Application

Module Module1
	Sub Main()
		Console.Write("Enter the first number: ") 'Writes the string to the console and stays on the same line
		Dim number1 As Integer = Console.ReadLine() 'Declare and assign the value entered by the user to the variable

		Console.Write("Enter the second number: ") 'Writes the string to the console and stays on the same line
		Dim number2 As Integer = Console.ReadLine() 'Declare and assign the value entered by the user to the variable

		Dim product As Integer = number1 * number2 'Declare and assign the values of the variables

		Console.WriteLine("The answer is: " & product) 'Displays the input from the user to the console
	End Sub
End Module