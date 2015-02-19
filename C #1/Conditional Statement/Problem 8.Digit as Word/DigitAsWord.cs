using System;
//Problem 8. Digit as Word
//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.
class DigitAsWord
{
    static void Main()
    {
        Console.Write("Please, enter a number from 0 to 9: ");
        string number = Console.ReadLine();
        string output;
        switch (number)
        {
            case "0":
                output = "ZERO";
                break;
            case "1":
                output = "ONE";
                break;
            case "2":
                output = "TWO";
                break;
            case "3":
                output = "THREE";
                break;
            case "4":
                output = "FOUR";
                break;
            case "5":
                output = "FIVE";
                break;
            case "6":
                output = "SIX";
                break;
            case "7":
                output = "SEVEN";
                break;
            case "8":
                output = "EIGHT";
                break;
            case "9":
                output = "NINE";
                break;
            default:
                output = "Not a digit !";
                break;
        }
        Console.WriteLine( output);
    }
}

