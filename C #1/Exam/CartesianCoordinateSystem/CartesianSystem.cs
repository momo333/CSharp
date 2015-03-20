using System;


namespace CartesianCoordinateSystem
{
    class CartesianSystem
    {
        static void Main()
        {
            int xCoord = int.Parse(Console.ReadLine());
            int yCoord = int.Parse(Console.ReadLine());

            if((xCoord==0) && (yCoord ==0))
            {
                Console.WriteLine(0);
            }
            else if((xCoord==0) && (yCoord!=0))
            {
                Console.WriteLine(5);
            }
            else if((xCoord!=0) && (yCoord==0))
            {
                Console.WriteLine(6);
            }
            else if((xCoord>0) && (yCoord>0))
            {
                Console.WriteLine(1);
            }
            else if ((xCoord > 0) && (yCoord < 0))
            {
                Console.WriteLine(4);
            }
            else if ((xCoord <0) && (yCoord > 0))
            {
                Console.WriteLine(2);
            }
            else if ((xCoord < 0) && (yCoord < 0))
            {
                Console.WriteLine(3);
            }
        }
    }
}
