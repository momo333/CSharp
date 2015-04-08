namespace Shapes
{
    using System;
    class ProgramTest
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                 new Triangle(3.5, 2.4),
                 new Circle(6.5),
                 new Rectangle(4.5,2.5)
            };
            Console.WriteLine("The are the areas of the different shape: ");
            Console.WriteLine(new string('-',30));
            for (int i = 0; i < shapes.Length; i++)
			{
			 Console.WriteLine("{0}", shapes[i].GetType().Name);
                double area = shapes[i].CalculateSurface();
                Console.WriteLine("{0:F2}", area);
			}
        }
    }
}
