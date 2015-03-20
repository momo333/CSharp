using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int[,] spiral = new int[number, number];
        string direction = "right";
        int currentRow = 0;
        int currentCol = 0;
        for (int i = 1; i < number; i++)
        {
            if (direction == "right" && currentCol >= number || (spiral[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow++;
                direction = "down";
            }
            else if (direction == "down" && currentRow >= number || (spiral[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow--; ;
                direction = "left";
            }
            else if (direction == "left" && currentCol < 0 || (spiral[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow--; ;
                direction = "up";
            }
            else if (direction == "up" && currentRow < 0 || (spiral[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow++; ;
                direction = "right";
            }
            spiral[currentRow, currentCol] = i;
            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
          
        }
        for (int row = 0; row < number; row++)
        {
            for (int col = 0; col < number; col++)
            {
                Console.Write(spiral[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

