using System;

class Program
{
    static void Main(string[] args)
    {
        bool[,] track = new bool[8, 8];

        for (int i = 0; i < 8; i++)
        {
            int currNumber = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                int mask = 1;
                track[i, j] = ((currNumber >> j) & mask) != 0;
            }
        }
        int row = 0;
        int col = 0;
        int pathCount = 0;
        int directCount = 0;
        bool exitFount = false;
        string direction = "down";
        string lastDir = "down";

        while (true)
        {

            if (track[row, col])
            {
                break;
            }
            pathCount++;
            if (row == 7 && col == 7)
            {
                exitFount = true;
                break;
            }
            if (direction == "down" && (row + 1 > 7 || track[row + 1, col]))
            {
                direction = "left";
                lastDir = "down";
                directCount++;
                if (col + 1 > 7 || track[row, col + 1])
                {
                    break;
                }
            }
            else if (direction == "up" && (row - 1 < 0 || track[row - 1, col]))
            {
                direction = "left";
                lastDir = "up";
                directCount++;
                if (col + 1 > 7 || track[row, col - 1])
                {
                    break;
                }
            }
            if (direction == "left" && lastDir == "down" && (col + 1 > 7 || track[row, col + 1]))
            {
                direction = "up";
                lastDir = "left";
                directCount++;
                if (row - 1 < 0 || track[row, col + 1])
                {
                    break;
                }
            }
            else if (direction == "left" && lastDir == "up" && (col > 7 || track[row, col + 1]))
            {
                direction = "down";
                lastDir = "left";
                directCount++;
                if (row + 1 > 7 || track[row, col + 1])
                {
                    break;
                }
            }
            if (direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {
                col++;
            }
            else if (direction == "up")
            {
                row--;
            }
        }

        if (exitFount)
        {
            Console.WriteLine(pathCount + " " + directCount);
        }
        else
        {
            Console.WriteLine("No" + pathCount);
        }
    }
}

