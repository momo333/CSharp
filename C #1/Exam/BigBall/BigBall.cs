using System;



class Program
{
    static void Main(string[] args)
    {
        
        int field = 8;
        int[,] matrix = new int[field, field];
        
        for (int i = 0; i < field; i++)
        {
         int number = int.Parse(Console.ReadLine());
             for (int j = 0; j < field; j++)
                {
                 int bit =(number >> j) & 1;
                 if(bit ==1)
                 {
                     matrix[i,j]=1;
                 }
            }  
        }

        for (int i = 0; i < field; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < field; j++)
            {
                int bit = (number >> j) & 1;
                if (bit == 1)
                {
                    if (matrix[i, j] == 1)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = 2;
                    }
                }
            }
        }
        int counter1 = 0;
        int counter2= 0; 
        for (int col = 0; col < field; col++)
        {
            for (int row = 0; row < field; row++)
            {
                if(matrix[row,col]==1)
                {
                    break;
                }
                else if(matrix[row,col]==2)
                {
                    counter2++;
                    break;
                }
            }
        }


        for (int col = 0; col < field; col++)
        {
            for (int row = field - 1; row >= 0; row--)
            {
                if (matrix[row, col] == 1)
                {
                    counter1++;
                    break;
                }
                else if (matrix[row, col] == 2)
                {
                    break;
                }
            }
            Console.WriteLine("{0}:{1}",counter1,counter2);
        }
    }
}

