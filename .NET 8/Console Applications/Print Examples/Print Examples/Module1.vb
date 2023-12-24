'Robert Calero
'Print Examples - VC# - Console Application

Module Module1

    Sub Main()
        Console.WriteLine("Hello World!") 'Writes text to the console, print with a newline at the end

        Console.Write("Something") 'print without a newline
        Console.WriteLine(" else")

        Console.WriteLine("Other ""stuff""") 'escape sequence

        Console.WriteLine("Rob     " & "tabs     " & "alot") 'tab

        Console.ReadLine() 'This pauses the program
    End Sub

End Module