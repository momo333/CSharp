using System;

//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
class Program
{
    static void Main()
    {
    float circleRad = 1.5f;
    int centerX = 1, centerY = 1;
    float pointX = 0f, pointY = 0f;
 
    bool isInCircle;
    bool isOutRect;
 
    Console.WriteLine("Provide point X coordinate:");
    while (!float.TryParse(Console.ReadLine(), out pointX))
    {
        Console.WriteLine("Please, enter valid integer.");
    }
 
    Console.WriteLine("\nProvide point Y coordinate:");
    while (!float.TryParse(Console.ReadLine(), out pointY))
    {
        Console.WriteLine("Please, enter valid integer.");
    }
 
    isInCircle = (Math.Pow((pointX - centerX), 2) + Math.Pow((pointY - centerY), 2)) <= Math.Pow(circleRad, 2);
    isOutRect = !(((pointX <= 5)&&(pointX >= -1)) && ((pointY <= 1)&&(pointY >= -1 )));
       
    Console.WriteLine("\n {0}",(isInCircle && isOutRect));
 
    Console.WriteLine("\nPress any key to exit.");
       
    Console.ReadKey();
    
    }
}

