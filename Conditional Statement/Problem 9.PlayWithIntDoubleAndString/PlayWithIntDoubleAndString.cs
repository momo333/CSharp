using System;
//Problem 8. Digit as Word
//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please, choose a type:\n1 - int\n2 - double\n3 - string");
        int choice = int.Parse(Console.ReadLine());
 
        switch (choice)
        {
            case 1: Console.Write("Please enter a integer: ");  
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a + 1);
                    break;
            case 2: Console.Write("Please enter a double: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b + 1.00);
                    break;
            case 3: Console.Write("Please enter a string: ");
                    string c = Console.ReadLine();
                    Console.WriteLine(c + "*");
                    break;
            default: Console.WriteLine("Invalid Input!"); break;
        }
    }
}

        