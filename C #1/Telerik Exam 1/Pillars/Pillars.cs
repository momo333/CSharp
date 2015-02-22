using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[8, 8];
        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                int mask = 1;
                matrix[i, j] = (number >> j) & mask;
            }
        }
        int pillar = 7;
        int countLeft = 0;
        int countRight = 0;
        bool foundSol = false;
        while (pillar >= 0)
        {
            countLeft = 0;
            countRight = 0;
            for (int i = 0; i < pillar; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(matrix[i,j]==1)
                    {
                        countLeft++;
                    }
                }
            }
            for (int i = pillar + 1; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        countRight++;
                    }
                }
            }
            if(countLeft==countRight)
            {
                foundSol = true;
                break;
            }
            pillar--;
        }
        if(foundSol)
        {
            Console.WriteLine(pillar);
            Console.WriteLine(countLeft);
        }
        else
            Console.WriteLine("No");
    }
}
