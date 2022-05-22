'Robert calero
'Feet to mile - VB - Console Application

Module Module1

    Sub Main()
        Dim feet_in_mile As Integer 'Variable declaration
        Dim yards_in_mile As Integer 'Variable declaration
        Dim feet_in_yard As Integer 'Variable declaration

        yards_in_mile = 1760 'Assigns a value to the variable
        feet_in_yard = 3 'Assigns a value to the variable

        feet_in_mile = yards_in_mile * feet_in_yard 'Multiplies 2 variables and assigns the value to another variable

        Console.WriteLine("Feet in a mile: " & feet_in_mile) 'Writes the variable value to the console and concatenates a string

        Console.ReadLine() 'This pauses the program
    End Sub

End Module