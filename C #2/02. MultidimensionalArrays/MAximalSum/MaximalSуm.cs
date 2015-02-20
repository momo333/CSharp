using System;
//Problem 2. Maximal sum
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class MaxSubMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter M: ");
        int col = int.Parse(Console.ReadLine());
        int[,] matrix = new int[row, col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write("Enter Element[{0}, {1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
        int sum = 0;
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int i = 0; i < row - 2; i++)
        {
            for (int j = 0; j < col - 2; j++)
            {
                sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                             matrix[i, j] + matrix[i + 1, j] + matrix[i + 2, j];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = i;
                    bestCol = j;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Best matrix 3X3: ");
        for (int i = bestRow; i < bestRow + 3; i++)
        {
            for (int j = bestCol; j < bestCol + 3; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }

    }
}




