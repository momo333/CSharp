using System;
 /*•	Write methods that calculate the surface of a triangle by given:
            o	Side and an altitude to it;
            o	Three sides;
            o	Two sides and an angle between them;
          •	Use System.Math.*/
class TriangleSurface
{
    static void SurfaceBySideAndAltitude()
    {
        double side = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());
        double surface = side * altitude / 2;
        Console.WriteLine("The surface of the triangle is: {0}", surface);
    }
    
    static void SurfaceByThreeSides()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double p = (a + b + c) / 2;
        double surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine("The surface of the triangle is: {0}", surface);
    }

    static void SurfaceByTwoSidesAndAngle()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());
        double surface =  a * b * Math.Sin(angle * Math.PI / 180) / 2;
        Console.WriteLine("The surface of the triangle is: {0}", surface);
    }

    static void Main()
    {
        Console.WriteLine("Please choose way to calculate the surface of the triangle:");
        Console.WriteLine("1. Side and altitude: ");
        Console.WriteLine("2. Three sides: ");
        Console.WriteLine("3. Two sides and angle between them: ");
        int choise = int.Parse(Console.ReadLine());
        switch(choise)
        {
            case 1:
                SurfaceBySideAndAltitude();
                break;
            case 2:
                SurfaceByThreeSides();
                break;
            case 3:
                SurfaceByThreeSides();
                break;
            default: Console.WriteLine("Invalid choise, please enter 1,2 or 3");
                break;
        }

    }
}

