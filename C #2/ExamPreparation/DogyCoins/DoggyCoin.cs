using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogyCoins
{
    class DoggyCoin
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] coins = new int[rows, cols];
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                string[] currCoords = Console.ReadLine().Split(' ');
                int currCoinRow = int.Parse(currCoords[0]);
                int currCoinCol = int.Parse(currCoords[1]);

                coins[currCoinRow, currCoinCol]++;
            }
            int[,] dp = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int maxAbove = 0;
                    int maxLeft = 0;
                    if(row - 1>=0)
                    {
                        maxAbove = dp[row - 1,col-1];
                    }
                    if(col-1>=0)
                    {
                        maxLeft = dp[row, col - 1];
                    }
                    dp[row, col] = Math.Max(maxAbove, maxLeft) +
                        coins[row, col];
                }
                Console.WriteLine(dp[rows-1,cols-1]);
            }

        }
    }
}
