using System;
//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

class CirclePerimeterandArea
{
    static void Main()
    {
        Console.WriteLine("Please enter the radius of the circle");
        double radius = double.Parse(Console.ReadLine());
        double Pi = Math.PI;

        double perimeter = 2 * Pi * radius;
        double area = Pi * radius * radius;
        Console.WriteLine("The area of the circle is {0:F2}", area);
        Console.WriteLine("The perimeter of the circle is: {0:F2}", perimeter);
    }
}

