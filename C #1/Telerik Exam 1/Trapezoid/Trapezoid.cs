using System;


namespace Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[,] arr = new int[number + 1, 2 * number];
            int height = number;
            int width = 2 * number;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if((i+j)==number)
                    {
                        arr[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i<height; i++)
            {
                for (int j = number; j < width; j++)
                {
                    arr[0,j]=1;
                }
            }
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    arr[i, width-1] = 1;
                }
            }
            string str = new string('*', number * 2);
           

            for (int i = 0; i < height; i++)
			{
                for (int j = 0; j < width; j++)
                {
                    if(arr[i,j]==1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                    
                }
                Console.WriteLine();
			}
            Console.WriteLine(str);
        } 
    }
}
