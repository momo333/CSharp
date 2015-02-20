using System;
//Problem 1. Fill the matrix
//Write a program that fills and prints a matrix of size (n, n) as shown below:

class Program
{
   
    static void MatrixA(int number)
    {
        int[,] array = new int[number, number];
        int count = 0;
        for (int i = 0; i < number; i++)
        {

            for (int j = 0; j < number; j++)
            {
                count++;
                array[j, i] = count;

            }
        }

        for (int i = 0; i < number; i++)
        {

            for (int j = 0; j < number; j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void MatrixB(int number)
    {
        int[,] array = new int[number, number];
        int k = 0;
        for (int i = 0; i < number; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 1; j <= number; j++)
                {
                    array[j - 1, i] = i + j + k;
                }
                k += 2 * number - 1;
            }
            else
            {
                for (int j = 0; j < number; j++)
                {
                    array[j, i] = i - j + k;
                }
                k -= 1;
            }
        }
        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void MatrixC(int number)
    {
        int[,] array = new int[number, number];
        int x = 3;
        int y = 0;
        for (int i = 1; i < number * number; i++)
        {
            array[x, y] = i;
            int sideX = x + 1;
            int sideY = y + 1;
            if (sideX == number && sideY != number)
            {
                x = (number - y - 2);
                y = 0;
            }
            else if (sideY == number)
            {
                y = number - x;
                x = 0;
            }
            else
            {
                x = sideX;
                y = sideY;
            }
        }
        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void MatrixD(int number)
    {

        int[,] newMatrix = new int[number, number];
        int counter = 1;
        Console.WriteLine();
        Console.WriteLine("Printing Matrix d)");
        int row = 0;
        int col = 0;
        string direction = "right";
        int maxRotations = number * number;


        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (col > number - 1 || newMatrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > number - 1 || newMatrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || newMatrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }

            if (direction == "up" && row < 0 || newMatrix[row, col] != 0)
            {
                direction = "right";
                row++;
                col++;
            }

            newMatrix[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                Console.Write("{0,4}", newMatrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter size of the matrix: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter choice for the matrix: 1,2,3,4");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1": MatrixA(number); break;
            case "2": MatrixB(number); break;
            case "3": MatrixC(number); break;
            case "4": MatrixD(number); break;
        }

    }
}

