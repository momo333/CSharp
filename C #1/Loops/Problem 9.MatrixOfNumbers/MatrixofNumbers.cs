using System;
//Problem 9. Matrix of Numbers
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1 2 3 4
//        2 3                 2 3 4               2 3 4 5
//                            3 4 5               3 4 5 6
//                                                4 5 6 7
class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool inRange = n >= 1 && n <= 20;
        if (inRange)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write(row + column + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}