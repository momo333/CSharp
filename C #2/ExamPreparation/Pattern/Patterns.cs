using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Patterns
    {
        static bool isPattern(int[,] matrix, int row, int col)
        {
            if ((matrix[row, col] == (matrix[row, col + 1] -1)) &&
                (matrix[row, col + 1] == (matrix[row, col + 2] - 1)) &&
                (matrix[row, col + 2] == (matrix[row + 1, col + 2] - 1)) &&
                (matrix[row + 1, col + 2] ==( matrix[row + 2, col + 2] - 1)) &&
                (matrix[row + 2, col + 2] == (matrix[row + 2, col + 3] - 1)) &&
                (matrix[row + 2, col + 3] == (matrix[row + 2, col + 4] - 1)))
            {
                return true;
            }
            else
                return false;
        }

        static long SumDiagonalElents(int[,] matrix)
        {
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sum += matrix[row, col];
                    }
                }
            }
            return (long)sum;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int maxSum = int.MinValue;
            for (int row = 0; row < n; row++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }
        
            bool hasMatch = false;
            long sumDiagonalElements = SumDiagonalElents(matrix);
            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < n - 4; col++)
                {
                    if (isPattern(matrix, row, col))
                    {
                        hasMatch = true;
                        int sum = SumOfElementsOfPatter(matrix, row, col);
                        if (maxSum < sum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            }
            if (hasMatch == true)
            {
                Console.WriteLine("YES {0}", maxSum);
            }
            else
                Console.WriteLine("NO {0}", sumDiagonalElements);
        }

        static int SumOfElementsOfPatter(int[,] matrix, int row, int col)
        {
            int sum = matrix[row, col] + matrix[row, col + 1] +
                  matrix[row, col + 2] + matrix[row + 1, col + 2] +
                  +matrix[row + 2, col + 2] + matrix[row + 2, col + 3] +
                  +matrix[row + 2, col + 4];
            return sum;
        }
    }
}
