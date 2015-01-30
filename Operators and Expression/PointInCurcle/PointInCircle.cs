using System;
//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Please intput coordinates X: ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Please intput coordinates Y: ");
        double y = double.Parse(Console.ReadLine());

        if (x*x + y*y <= 4)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

