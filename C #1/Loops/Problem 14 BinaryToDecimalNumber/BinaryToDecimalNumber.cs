using System;
//Problem 13. Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

class BinaryToDecimal
{
    static void Main()
    {
        double sum = 0;
        int number = int.Parse(Console.ReadLine()); // binary number
        int strn = number.ToString().Length; //how many digits has the number
        for (int i = 0; i < strn; i++)
        {
            int lastDigit = number % 10; // get the last digit
            sum = sum + lastDigit * (Math.Pow(2, i));
            number = number / 10; //remove the last digit
        }
        Console.WriteLine(sum);
    }
}
