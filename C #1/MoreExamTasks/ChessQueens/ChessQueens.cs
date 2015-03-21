using System;

class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int counter = 0;
        string[,] board = new string[size, size];
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                board[row, col] = " " + (char)('a' + row) + (col + 1);
            }
        }
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (row + distance + 1 <= board.GetLength(row))
                {
                    Console.WriteLine("{0} - {1}", board[row,col], board[row+distance+1,col]);
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

