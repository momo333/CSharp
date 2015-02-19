using System;
//Problem 1. Exchange If Greater
//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers");
        Console.WriteLine("Enter the first number");
        double numberOne = double.Parse(Console.ReadLine());     //double type of variable becouse if I want to exchange numbers with floating point

        Console.WriteLine("Enter the second number");
        double numberTwo = double.Parse(Console.ReadLine());    //double type of variable becouse if I want to exchange numbers with floating point

        if (numberOne > numberTwo)
        {
            double c;    //double type variable becouse we cannot exchange integer with double
            c = numberOne;
            numberOne = numberTwo;
            numberTwo = c;
            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);
        }
    }
}

