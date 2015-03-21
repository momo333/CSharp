using System;

namespace InsideTheBuilding
{
    class InsideTheBuilding
    {
        static bool isInTheBuilding (int x, int y, int side)
        {
            bool insideDown =
           (x >= 0) && (x <= 3 * side) && (y >= 0) && (y <= side);
            bool insideUp =
                (x >= side) && (x <= 2 * side) && (y >= side) && (y <= 4 * side);
            bool inside = insideDown | insideUp;
            return inside;
        }
        static void Main()
        {
             int numH = int.Parse(Console.ReadLine());
             int x1 = int.Parse(Console.ReadLine());
             int y1 = int.Parse(Console.ReadLine());
             int x2 = int.Parse(Console.ReadLine());
             int y2 = int.Parse(Console.ReadLine());
             int x3 = int.Parse(Console.ReadLine());
             int y3 = int.Parse(Console.ReadLine());
             int x4 = int.Parse(Console.ReadLine());
             int y4 = int.Parse(Console.ReadLine());
             int x5 = int.Parse(Console.ReadLine());
             int y5 = int.Parse(Console.ReadLine());
             
           if(isInTheBuilding(x1,y1,numH))
           {
               Console.WriteLine("inside");
           }
           else
               Console.WriteLine("outside");
           if (isInTheBuilding(x2, y2, numH))
           {
               Console.WriteLine("inside");
           }
           else
               Console.WriteLine("outside");
           if (isInTheBuilding(x3, y3, numH))
           {
               Console.WriteLine("inside");
           }
           else
               Console.WriteLine("outside");
           if (isInTheBuilding(x4, y4, numH))
           {
               Console.WriteLine("inside");
           }
           else
               Console.WriteLine("outside");
           if (isInTheBuilding(x5, y5, numH))
           {
               Console.WriteLine("inside");
           }
           else
               Console.WriteLine("outside");
        }
    }
}
