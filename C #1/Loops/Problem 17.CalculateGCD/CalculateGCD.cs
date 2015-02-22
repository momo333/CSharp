using System;
//Problem 15. Hexadecimal to Decimal Number
//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

class EucledeanAlgorithm
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a == 0 || b == 0)
        {
            Console.WriteLine("Enter two positive numbers:");
            Main();
        }
        else
        {
            while (a > b || b > a)
            {
                while ((a - b) > 0)
                {
                    a = a - b;

                }
                while ((b - a) > 0)
                {
                    b = b - a;
                }

            }
            Console.WriteLine("GCD = {0}", a);
        }
    }
}