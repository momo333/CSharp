using System;
//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.

class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("The program compares three entered numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

 
        Console.WriteLine("The biggest number is: " + Math.Max(Math.Max(a, b), c));

    }
}

