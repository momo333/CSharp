using System;
using System.Numerics;
//Problem 18.* Trailing Zeroes in N!
//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        string factorialString = factorial.ToString();
        for (int i = factorialString.Length - 1; i >= 0; i--)
        {
            if (factorialString[i] == '0')
            {
                count++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(count);
    }
}