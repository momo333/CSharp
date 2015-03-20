using System;


namespace ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[,] arr = new int[(2 * number - 1), number];
            for (int i = 0; i < 2*number - 1; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if(i==j)
                    {
                        arr[i, j] = 1;
                    }

                    if((i + j)==(2*number - 2))
                    {
                        arr[i, j] = 1;
                    }
                }
            }

                for (int t = 0; t < (2*number - 1); t++)
                {
                    for (int j = 0; j < number; j++)
                        {
                        if(arr[t,j]==1)
                            Console.Write('*');
                        else
                        {
                            Console.Write('.');
                        }
                        }
                         Console.WriteLine();
                }
                
	    }
			 
    }
 }
   