using System;

//Problem 1. Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum.

    class SumofThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("The program calculates the sum of three numbers");
        Console.WriteLine("Please enter number a ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number b ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number c ");
        double c = double.Parse(Console.ReadLine());

        double sum = a + b + c;
        Console.WriteLine("The sum of the numbers is : {0}", sum);
    }
}

