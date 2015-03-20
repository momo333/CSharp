using System;


namespace UKFlag
{
    class UKFlag
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[,] arr = new int[number, number];
            
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if(i==j && (i!=number/2))
                    {
                        arr[i, j] = 1;
                    }
                    else if(((i+j)==number-1) && (i!=number/2))
                    {
                        arr[i, j] = 3;
                    }
                    arr[i, number / 2] = 2;
                    arr[number/2,j]=6;
                    arr[number / 2, number / 2] = 4;
                }
            }
            
          

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (arr[i,j]==1)
                    {
                        Console.Write('\\'); 
                    }
                    else if(arr[i,j]==2)
                    {
                        Console.Write('|'); 
                    }
                    else if (arr[i, j] == 3)
                    {
                        Console.Write('/');
                    }
                    else if (arr[i, j] == 0)
                    {
                        Console.Write('.');
                    }
                    else if (arr[i, j] == 4)
                    {
                        Console.Write('*');
                    }
                    else if (arr[i, j] == 6)
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
