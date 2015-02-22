﻿using System;
//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.
class CalculateFactorialFormula
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        double factN = 1;
        double multplicate = 1;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            multplicate *= x;
            result += factN / multplicate;
        }

        Console.WriteLine("{0:F5}", result);
    }
}