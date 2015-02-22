using System;
//•	Write a program to convert binary numbers to their decimal representation.
class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a number in binary representation: ");
        double sum = 0;
        int number = int.Parse(Console.ReadLine()); // binary number
        int strn = number.ToString().Length; //how many digits has the number
        for (int i = 0; i < strn; i++)
        {
            int lastDigit = number % 10; // get the last digit
            sum = sum + lastDigit * (Math.Pow(2, i));
            number = number / 10; //remove the last digit
        }
        Console.WriteLine("The numbe in decimal repreentation is: {0}", sum);
    }
}

