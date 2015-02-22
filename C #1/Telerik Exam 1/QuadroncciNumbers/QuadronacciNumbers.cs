using System;


class Program
{
    static void Main(string[] args)
    {
        long firstNumber = int.Parse(Console.ReadLine());
        long secNumber = int.Parse(Console.ReadLine());
        long thirdNumber = int.Parse(Console.ReadLine());
        long forthNumber = int.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        long result;


        if (cols == 4)
        {
            Console.WriteLine(firstNumber + " " + secNumber + " " +
                thirdNumber + " " + forthNumber + " " );
        }
        else
        {
            Console.WriteLine(firstNumber + " " + secNumber + " " + 
                thirdNumber + " " + forthNumber + " ");
        }
        for (int row = 0; row <rows; row++)
        {
            int curretCol = 0;
            if(row ==0)
            {
                curretCol = 4;
            }
            for (int col = curretCol; col < cols; col++)
            {
                result = firstNumber + secNumber + thirdNumber + forthNumber;
                firstNumber = secNumber;
                secNumber = thirdNumber;
                thirdNumber = forthNumber;
                forthNumber = result;

                if(col + 1 == cols)
                {
                    Console.WriteLine(result);
                }
                
                else
                {
                    Console.Write(result + " " );
                }
            }
            Console.WriteLine();
        }
    }
}

