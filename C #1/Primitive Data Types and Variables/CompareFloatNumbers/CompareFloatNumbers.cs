using System;
//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter the first number :");
        decimal firstNum = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number :");
        decimal secondNum = decimal.Parse(Console.ReadLine());

        if (Math.Abs(firstNum - secondNum) < 0.000001m)
            Console.WriteLine("The two numbers are equal with precision 0.000001");
        else
            Console.WriteLine("Difference between numbers (or equal to) 0.000001");
    }
}