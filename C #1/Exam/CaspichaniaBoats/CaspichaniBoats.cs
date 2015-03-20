using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int width = 2*number + 1;
        int height = 6+(((number -3)/2)*3);
        int[,] arr = new int[height, width];

        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                if((i + j)==number)
                {
                    arr[i, j] = 1;
                }
            }
        }
        for (int i = 0; i < height; i++)
        {
            arr[i, number] = 1;
        }
       
        for (int i = 0; i <number; i++)
        {
            for (int j = number + 1; j <width; j++)
            {
               if((j-i)==number)
               {
                   arr[i, j] = 1;
               }
  
            }
        }
        for (int i = number; i < height; i++)
        {
            for (int j = 0; j < number; j++)
            {
                if ((i-j) == number)
                {
                    arr[i, j] = 1;
                }

            }
        }
        for (int i = number + 1; i < height; i++)
        {
            for (int j=number; j < width; j++)
            {
                if ((j + i) ==(3* number))
                {
                    arr[i, j] = 1;
                }
            }
        }
        for (int i = 0; i < height-1; i++)
        {
            for (int j = 0; j < width; j++)
            {
                arr[i,number] = 1;
                arr[number,j] = 1;
                
            }
        }
        for (int i = height-1; i < height; i++)
        {
            for (int k = (width-number)/2 + 1; k <=((width -number)/2 + number -1); k++)
            {
                arr[i,k]=1;
            }
        }
        
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if(arr[i,j]==1)
                {
                    Console.Write('*');
                }
                else if(arr[i,j]==0)
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}