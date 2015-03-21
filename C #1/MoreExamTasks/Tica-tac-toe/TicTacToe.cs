using System;
using System.Numerics;

namespace Tica_tac_toe
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            int num = int.Parse(Console.ReadLine());
            int col = x;
            int row = y;
            int[,] array = {{1,2,3},
                           {4,5,6},
                           {7,8,9}};
            int[,] matrix = new int[3,4];
            int index = array[y, x];
            BigInteger number = 0;
            for (int i= 0; i< 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = num;
                    num++;
                }
            }
            number = matrix[y, x];
            BigInteger multiplication = 1;
            for (int i = 0; i < index; i++)
            {
                multiplication *= number;
            }
            Console.WriteLine(multiplication);
        }
    }
}
