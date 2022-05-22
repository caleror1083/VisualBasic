'Robert Calero
'Loops VB-Console Application

Module Module1

    Sub Main()
        Console.WriteLine("Loop Examples") 'Writes text to the console
        Console.WriteLine() 'Writes a blank line to the console

        Dim int1 As Integer
        Dim int2 As Integer = 0
        Dim int3 As Integer

        'For loop
        For int1 = 1 To 20
            Console.WriteLine("The number equals: " & int1)
        Next

        Console.WriteLine() 'Writes a blank line to the console

        'Exit the For loop before it is finished
        For int1 = 1 To 20
            Console.WriteLine("The number equals: " & int1)
            If int1 = 15 Then Exit For
        Next

        Console.WriteLine() 'Writes a blank line to the console

        'Continue statement
        For int1 = 1 To 20
            If int1 = 5 Then Continue For
            Console.WriteLine("The number equals: " & int1)
        Next

        Console.WriteLine() 'Writes a blank line to the console

        'For loop with Step Operator
        For int1 = 0 To 20 Step 5
            Console.WriteLine("The number equals: " & int1)
        Next

        Console.WriteLine() 'Writes a blank line to the console

        For int1 = 1 To 10
            For int3 = 1 To 10
                Console.Write(int3)
            Next
            Console.WriteLine()
        Next

        Console.WriteLine() 'Writes a blank line to the console

        'Do Until loop
        Do Until int2 = 10
            Console.WriteLine("The number equals: " & int2)
            int2 += 1
        Loop

        Console.WriteLine() 'Writes a blank line to the console

        'Exit the Do loop
        Do Until int2 = 10
            If int2 = 5 Then Exit Do
            Console.WriteLine("The number equals: " & int2)
            int2 += 1
        Loop

        Console.WriteLine() 'Writes a blank line to the console

        'Do While loop
        Do While int2 <= 15
            Console.WriteLine("The number equals: " & int2)
            int2 += 1
        Loop

        Console.ReadLine() 'This pauses the program
    End Sub

End Module