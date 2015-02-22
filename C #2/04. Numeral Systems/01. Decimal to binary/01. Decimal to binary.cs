using System;
//•	Write a program to convert decimal numbers to their binary representation.
class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Please enter a number in decimal form ");
        long decNumber = long.Parse(Console.ReadLine());
        string binNumber = "";
        while (decNumber != 0)
        {
            int remain = (int)decNumber % 2;
            decNumber /= 2;
            binNumber = remain + binNumber;
        }
        Console.WriteLine(binNumber);
    }
}
