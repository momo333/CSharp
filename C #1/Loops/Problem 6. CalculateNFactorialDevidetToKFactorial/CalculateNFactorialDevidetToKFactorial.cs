using System;
using System.Numerics;
//Problem 6. Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

class CalculateNFactorialDevidetToKFactorial
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        if (n > 1 && k > 1 && n < 100 && k < 100)
        {
            BigInteger factN = 1;
            BigInteger factK = 1;
            BigInteger result = 0;

            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }

            for (int j = 1; j <= k; j++)
            {
                factK *= j;
            }

            result = factN / factK;

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}