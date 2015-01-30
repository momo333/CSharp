using System;
using System.Linq;
//Problem 4. Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

class Program
{
    static void Main(string[] args)
    {
        int numA = int.Parse(Console.ReadLine());
        int numB = int.Parse(Console.ReadLine());
        int biggerNum = Math.Max(numA, numB);
        Console.WriteLine(biggerNum);
    }
}

