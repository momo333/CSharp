using System;
using System.Globalization;
//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.
class Program
{
    static void Main()
    {
        Console.WriteLine("The program compares three entered numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b)
            if (a > c)
            {
                Console.WriteLine("The Greatest Of Three numbers are:" + a);
            }
            else
            {
                Console.WriteLine("The Greatest Of Three numbers are:" + c);
            }
        else
            if (b > c)
            {
                Console.WriteLine("The Greatest Of Three numbers are:" + b);
            }
            else
            {
                Console.WriteLine("The Greatest Of Three numbers are:" + c);
            }
    }
}

       
