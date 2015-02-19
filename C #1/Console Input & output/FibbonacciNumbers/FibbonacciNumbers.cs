using System;
using System.Numerics;
//Problem 10. Fibonacci Numbers
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

class FibbonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("The program reads the first n numbers from the Fibonacci row");
        int n = int.Parse(Console.ReadLine());

        BigInteger fibonacciFirstNumber = 0;
        BigInteger fibonaccisecondNumber = 1;

        Console.WriteLine(fibonacciFirstNumber);
        Console.WriteLine(fibonaccisecondNumber);
        BigInteger thirdNumber = 0;
        for (int i = 2; i < n; i++)
        {
            thirdNumber = fibonaccisecondNumber + fibonacciFirstNumber;
            Console.WriteLine(thirdNumber + " ");      
            fibonacciFirstNumber = fibonaccisecondNumber;
            fibonaccisecondNumber = thirdNumber;
        }
    }
}

