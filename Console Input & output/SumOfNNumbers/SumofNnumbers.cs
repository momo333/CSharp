using System;
//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

public static class SumOfNNumbers
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        decimal sum = 0.00m;
        decimal number = decimal.MinValue;
        for (int i = 0; i < n; i++)
        {
            number = decimal.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}
