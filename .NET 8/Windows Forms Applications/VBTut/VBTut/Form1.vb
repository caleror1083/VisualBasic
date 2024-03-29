﻿' This code defines what happens with your form
' We define how to handle events like a mouse click on the button
' You can create multiline Text Boxes by setting Multiline to True
' Scrollbars to Vertical and Wordwrap to True
Public Class Form1

    ' This is a subroutine that doesn't return a value
    ' This code runs every time the button is clicked
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' & is used to join or concatenate strings
        ' txtName.Text returns the value stored in the Text Box
        ' You can also assign values using txtName.Text
        txtName.Text = "Hello " & txtName.Text
    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        ' Opens a message box and says hello to the user. The text after the , is shown in the message box title bar
        MessageBox.Show("Hello " & txtName.Text, " This is the title " & txtName.Text)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Will close the program
        Me.Close()
    End Sub

    Private Sub btnAddValues_Click(sender As Object, e As EventArgs) Handles btnAddValues.Click
        ' If an error could occur surround the error causing code
        ' with a Try block
        Try
            ' Create an Integer variable and store the value
            ' Integers can hold values -2147483648 through +2147483647
            ' A Long holds -9,223,372,036,854,775,808 through 9,223,372,036,854,775,807 
            ' Decimal holds +/-79,228,162,514,264,337,593,543,950,335 and is precise to 29 decimal places
            ' Doubles hold +/-1.79769313486231570E+308 but are not precise
            ' Booleans are True or False
            ' Use CInt() to convert a String into an Integer
            Dim firstNum As Integer = CInt(txtAddVal1.Text)
            Dim secondNum As Integer = CInt(txtAddVal2.Text)

            ' Sum the values
            Dim sum = firstNum + secondNum

            ' Convert the Integer into a String
            ' You could also use sum.ToString
            txtSumAnswer.Text = CStr(sum)

            ' Catch the likely error to avoid crashing your program
        Catch Exc As System.InvalidCastException
            MessageBox.Show("Please enter numbers to sum", "Error")

            ' Print to the Output console
            Console.WriteLine("An error occurred")

        Catch Exc As Exception
            MessageBox.Show("An unknown error occurred", "Error")

        End Try

        ' Other common cast options
        ' CBool : Convert to a Boolean
        ' CDbl : Convert to Double
        ' CDec : Convert to Decimal
        ' CLng : Convert to Long
    End Sub

    Private Sub btnDivideValues_Click(sender As Object, e As EventArgs) Handles btnDivideValues.Click
        ' Create Decimals and convert from String
        Dim firstNum As Decimal = CDec(txtDivideVal1.Text)
        Dim secondNum As Decimal = CDec(txtDivideVal2.Text)

        ' Divide Decimals and then convert the answer into an Integer
        Dim intSolution As Integer = CType(firstNum / secondNum, Integer)

        txtDivisionAnswer.Text = CStr(intSolution)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' If you don't assign a type a default will be chosen
        ' based on the value assigned
        Dim randomNumber = 12.2
        TextBox1.Text = TypeName(randomNumber)

        ' ---------- Math Functions ----------
        ' You join strings with other data with &
        ' Environment.NewLine adds the platform specific newline
        Dim txtOutput As String = "Abs(-19) = " & Math.Abs(-19) & Environment.NewLine

        ' &= is a shortcut you can use to join a string with
        ' the original string
        txtOutput &= "Ceiling(4.5) = " & Math.Ceiling(4.5) & Environment.NewLine

        txtOutput &= "Floor(4.5) = " & Math.Floor(4.5) & Environment.NewLine

        ' 2.718 e raised to the specified power
        txtOutput &= "Exp(1) = " & Math.Exp(1) & Environment.NewLine

        ' Return the natural log
        txtOutput &= "Log(2.718) = " & Math.Log(2.718) & Environment.NewLine

        ' Return base 10 log
        txtOutput &= "Log10(3000) = " & Math.Log10(3000) & Environment.NewLine

        ' Return the larger number
        txtOutput &= "Max(5,4) = " & Math.Max(5, 4) & Environment.NewLine

        ' Return the smaller number
        txtOutput &= "Min(5,4) = " & Math.Min(5, 4) & Environment.NewLine

        ' Return the number to the power of number
        txtOutput &= "Pow(5,2) = " & Math.Pow(5, 2) & Environment.NewLine

        ' Return the sqrt
        txtOutput &= "Sqrt(25) = " & Math.Sqrt(25) & Environment.NewLine

        ' Round a Decimal or Double
        txtOutput &= "Round(4.5) = " & Math.Round(4.5) & Environment.NewLine

        ' There is also Cos, Sin, Tan, Acos, Asin, Atan, Cosh, Sinh, Tanh

        ' You can add, subtract, multiply and divide a number
        ' and save it back to itself
        Dim randInt = 10
        randInt += 10
        txtOutput &= "10 + 10 = " & randInt & Environment.NewLine

        ' If you save to an integer it stays an integer
        randInt *= 0.13
        txtOutput &= "20 * .13 = " & randInt & Environment.NewLine

        TextBox1.Text = txtOutput

        ' ---------- Strings ----------
        txtOutput = ""

        Dim randStr As String = "This is a string"

        ' Get the length of a String
        txtOutput &= "randStr Length = " & randStr.Length & Environment.NewLine

        ' Start at index 0 and return the next 3 letters
        txtOutput &= "1st 3 = " & randStr.Substring(0, 3) & Environment.NewLine

        ' Replace a string
        randStr = randStr.Replace("string", "sentence")
        txtOutput &= "Changed String = " & randStr & Environment.NewLine

        ' Formatting a Decimal
        Dim decRandNum As Decimal = 3123.14159

        ' Add thousands separator and only 3 decimals 
        txtOutput &= "Pi = " & String.Format("{0:n3}", decRandNum) & Environment.NewLine

        ' Add thosands separator and treat as currency
        txtOutput &= "Pi Currency = " & String.Format("{0:c}", decRandNum) & Environment.NewLine

        ' Display 5 numbers before the decimal and 1 after
        txtOutput &= "Pi Random = " & String.Format("{0:00000.0}", decRandNum) & Environment.NewLine

        ' g Displays without thousands separator
        ' f Displays with at least 1 number on the left and right
        ' of the decimal
        ' p Multiplies the number times 100 and shows %
        ' e Display in exponential notation

        ' Get the 1st location of a string
        ' Define 1st character to start with, string to search,
        ' string to search for 
        txtOutput &= "is in String = " & InStr(1, randStr, "i", CompareMethod.Text) & Environment.NewLine

        ' Create a fixed size array
        ' Arrays are used to store multiple values
        Dim arrayEmployees(0 To 2) As String
        arrayEmployees(0) = "Bob"
        arrayEmployees(1) = "Sally"
        arrayEmployees(2) = "Paul"

        ' Join array values in a string
        Dim strEmployees As String = Join(arrayEmployees, ", ")

        txtOutput &= "Employees = " & strEmployees & Environment.NewLine

        ' Split a string into an array
        arrayEmployees = Split(strEmployees, ", ")

        txtOutput &= "Employees = " & arrayEmployees.ToString & Environment.NewLine

        ' For loop for cycling through an array
        ' i increments each time through the loop until
        ' its value is arrayEmployees.Length - 1
        For i As Integer = 0 To arrayEmployees.Length - 1
            txtOutput &= "Employee = " & arrayEmployees(i) & Environment.NewLine
        Next

        ' Return the left 3 characters
        txtOutput &= "Left 3 = " & Strings.Left(randStr, 3) & Environment.NewLine

        ' Return the right 3 characters
        txtOutput &= "Right 3 = " & Strings.Right(randStr, 3) & Environment.NewLine

        ' Return uppercase
        txtOutput &= "Uppercase = " & UCase(randStr) & Environment.NewLine

        ' Return lowercase
        txtOutput &= "Lowercase = " & LCase(randStr) & Environment.NewLine

        ' Reverse string
        txtOutput &= "Reverse = " & StrReverse(randStr) & Environment.NewLine

        ' Compare 2 strings
        ' Returns -1 if 1 sorts ahead of 2
        ' Returns 0 if they are equal
        ' Returns 1 if 1 sorts after 2
        txtOutput &= "Dog Compare Cat = " & StrComp("Dog", "Cat", CompareMethod.Text) & Environment.NewLine

        ' Trim whitespace
        ' There is also LTrim and RTrim
        txtOutput &= "Trim = " & Trim("   string   ") & Environment.NewLine

        ' ---------- Dates ----------

        txtOutput = ""

        ' Create a date with the current time
        Dim dteCurrent As Date = Now

        ' Get the month
        txtOutput &= "Month = " & dteCurrent.Month & Environment.NewLine

        ' Get the day
        txtOutput &= "Day = " & dteCurrent.Day & Environment.NewLine

        ' Get the year
        txtOutput &= "Year = " & dteCurrent.Year & Environment.NewLine

        ' Get the hour
        txtOutput &= "Hour = " & dteCurrent.Hour & Environment.NewLine

        ' Get the minute
        txtOutput &= "Minute = " & dteCurrent.Minute & Environment.NewLine

        ' Get the second
        txtOutput &= "Second = " & dteCurrent.Second & Environment.NewLine

        ' Get the day name
        txtOutput &= "Day = " & dteCurrent.ToString("dddd") & Environment.NewLine

        ' Get the day name
        txtOutput &= "Month = " & dteCurrent.ToString("MMMM") & Environment.NewLine

        ' Set a date
        dteCurrent = #12/21/1974 11:32:00 AM#

        ' Get the whole time and date
        txtOutput &= "Date = " & dteCurrent.ToLongTimeString & dteCurrent.ToLongDateString & Environment.NewLine

        ' ---------- Methods ----------
        ' We use functions to promote code reuse and to break
        ' code into parts so it is easier to understand
        ShowMessage()

        ' Call a function
        txtOutput &= "6 + 5 = " & GetSum(6, 5) & Environment.NewLine

        ' Pass a variable to a function
        Dim intVal As Integer = 10

        ' The value and not the variable is passed to a function
        ' so what happens to it in the function is temporary
        ChangeVal(intVal)

        txtOutput &= "intVal out of Func 1 = " & intVal & Environment.NewLine

        ChangeVal2(intVal)

        txtOutput &= "intVal out of Func 2 = " & intVal & Environment.NewLine

        txtOutput &= "1 + 2 + 3 + 4 = " & GetSumMore(1, 2, 3, 4) & Environment.NewLine

        TextBox1.Text = txtOutput
    End Sub

    ' Create a subroutine that opens a MessageBox
    Private Sub ShowMessage()
        'MessageBox.Show("Hello Again", "Love Saying Hello")
    End Sub

    ' Functions can return values
    Private Function GetSum(num1 As Integer, num2 As Integer)
        Return num1 + num2
    End Function

    Private Sub ChangeVal(intVal As Integer)
        intVal = 20
        'MessageBox.Show("intVal in Func 1 = " & intVal, "Change Value")
    End Sub

    ' You can define that you want to be able to change the value
    ' outside of a function with ByRef
    Private Sub ChangeVal2(ByRef intVal As Integer)
        intVal = 30
        'MessageBox.Show("intVal in Func 2 = " & intVal, "Change Value")
    End Sub

    ' You can accept a variable number of parameters
    Private Function GetSumMore(ByVal ParamArray Numbers() As Integer)
        Dim sum As Integer = 0

        For i As Integer = 0 To Numbers.Length
            sum += i
        Next

        Return sum

    End Function
End Class