using System;
//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.
class Program
{
    static void Main()
    {
        Console.WriteLine("The program calculates the are of trapezoid");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) * h) / 2;
        Console.WriteLine("The are of the trapezoid is : {0}", area);
    }
}

