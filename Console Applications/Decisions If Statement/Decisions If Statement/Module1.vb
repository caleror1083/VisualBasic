'Robert Calero
'Decisions-If Statement VB-Console Application

Module Module1

    Sub Main()
        Console.WriteLine("Decisions If Statements Example") 'Writes text to the console
        Console.WriteLine() 'Writes a blank line to the console

        Dim age As Integer = Nothing
        Dim myInt As Integer = Nothing
        Dim hasInsurance As Boolean = Nothing
        Dim isInKindergarten As Boolean = Nothing
        Dim canDrink As Boolean = Nothing
        Dim isSeniorCitizen As Boolean = Nothing
        Dim outcomeK As String = Nothing
        Dim outcomeD As String = Nothing
        Dim outcomeS As String = Nothing
        Dim myString As String = Nothing
        Dim myDouble As Double = Nothing

        Console.WriteLine("Enter a String: ")
        myString = Console.ReadLine()

        Console.WriteLine("Enter a Decimal: ")
        myDouble = Console.ReadLine()

        Console.WriteLine("Enter an integer: ")
        myInt = Console.ReadLine()

        Console.Write("What is your name? ") 'Writes text to the console
        Dim userName As String = Console.ReadLine() 'Declare and assign the value entered by the user to the variable

        Console.Write("What is your password? ") 'Writes text to the console
        Dim userPassword As String = Console.ReadLine() 'Declare and assign the value entered by the user to the variable

        'If Statement
        If userName = "Rick" Then
            Console.WriteLine("Welcome " & userName & "!")
            'Else If
        ElseIf userName = "Glenn" Then
            Console.WriteLine("Welcome " & userName & "!")
            'Else
        Else
            Console.WriteLine("Not a valid user")
        End If

        If userPassword = "Paterson216" Then
            Console.Write("Welcome")
        End If
        Console.WriteLine() 'Writes a blank line to the console

        Console.Write("What is your age? ") 'Writes text to the console
        age = Console.ReadLine()

        Console.Write("Do you have insurance? true/false? ") 'Writes text to the console
        hasInsurance = Console.ReadLine()

        'Nested If
        If age = 17 Then
            If hasInsurance = True Then
                Console.WriteLine("You can drive")
            Else
                Console.WriteLine("Watch out!")
            End If
        Else
            Console.WriteLine("You can't drive")
        End If

        'Conditional Operators
        If age <> 5 Then
            isInKindergarten = False
            outcomeK = "You aren't in Kindergarten"
        Else
            isInKindergarten = True
            outcomeK = "You are in Kindergarten"
        End If

        If age >= 65 Then
            isSeniorCitizen = True
            outcomeS = "You are a senior"
        Else
            isSeniorCitizen = False
            outcomeS = "You aren't a senior"
        End If

        If age >= 21 Then
            canDrink = True
            outcomeD = "You can drink"
        Else
            canDrink = False
            outcomeD = "You can't drink"
        End If

        Console.WriteLine(outcomeD & " " & outcomeK & " " & outcomeS)

        'Logical Operators
        If (userName = "Rob" Or userName = "Lance") And userPassword.Length = 12 Then
            Console.WriteLine("Yooooo " & userName)
        Else
            Console.WriteLine("No access")
            Console.WriteLine(userName.Substring(0, 2)) 'Formats string to the first 2 characters
        End If

        Console.WriteLine(String.Format("{0:n2}", myDouble)) 'Formats decimal value to 2 places
        Console.WriteLine(myString.ToUpper()) 'Formats string to all uppercase
        Console.WriteLine(myString.ToLower()) 'Formats string to all lowercase

        'Select Case
        Select Case myInt
            Case 0
                Console.WriteLine("Hello")
            Case 1
                Console.WriteLine("Bye")
            Case 2
                Console.WriteLine("Good morning")
        End Select

        'Select Case Else
        Select Case myString.ToLower()
            Case "Hello"
                Console.WriteLine("Goodbye")
            Case "Goodbye"
                Console.WriteLine("Hello")
            Case "Fishing"
                Console.WriteLine("Boat")
            Case Else
                Console.WriteLine("Huh")
        End Select

        Console.ReadLine() 'This pauses the program
    End Sub

End Module