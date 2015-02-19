using System;
//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.
class Rectangles
{
    static void Main()
    {
        Console.WriteLine("The program calculates the Area and Perimeter of rectangle");
        double width = int.Parse(Console.ReadLine());
        double height = int.Parse(Console.ReadLine());

        double area = width * height;
        double perimeter = 2 * (width + height);

        Console.WriteLine("The area of the rectagle is: {0}", area);
        Console.WriteLine("The Perimeter of the rectagle is: {0}", perimeter);
    }
}

