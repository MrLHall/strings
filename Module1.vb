Module Module1

    Sub Main()
        Dim myString As String = "This is a string I have made, I love CS"
        Console.WriteLine(myString)
        Console.WriteLine(myString.Length)
        Console.WriteLine(myString(3)) 'one char index 3
        Console.WriteLine(myString(myString.Length - 1)) 'one char index last 

        Console.WriteLine(myString.Substring(17)) 'one char index 17
        Console.WriteLine(myString.Substring(17, 11)) 'substring starting at 17, length of 11

        Console.WriteLine("my message is >>" + myString)
        Console.WriteLine("my message is >>" & myString)
        Console.WriteLine($"my message is >>{myString}")

        Dim secondString As String = "Room: B106"
        Dim thirdString As String = "teacher: Mr Hall"

        Console.WriteLine(myString + " " + secondString + " " + thirdString) 'concat of all variables
        Console.WriteLine($"{myString} {secondString} {thirdString}") 'interpolation of all varaibles
        Console.WriteLine("{0} {1} {2}", myString, secondString, thirdString) ' using builder of all varaibles
        Console.WriteLine($"{myString.Substring(30, 6)} {thirdString.Substring(9)} in {secondString.Substring(6, 4)}") 'concat a string to say "I love Mr Hall in B106"


        Dim year As String = Console.ReadLine()
        Dim firstName As String = Console.ReadLine()
        Dim surname As String = Console.ReadLine()
        Console.WriteLine($"your username is {year}{firstName(0)}{surname}")

    End Sub

End Module
