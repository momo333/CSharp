using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 8;
        int[,] matrix = new int[num, num];
        for (int i = 0; i < num; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < num; j++)
            {
                int bit = (number >> j) & 1;
                matrix[i, j] = bit;
            }
        }
        int longestLine = 0;
        int longestCount = 0;
        for (int i = 0; i < num; i++)
        {
            int currLine = 0;
            for (int j = 0; j < num; j++)
            {
                while(j<num && matrix[i,j]==1)
                {
                    currLine++;
                    j++;
                }
                if (currLine > longestLine)
                {
                    longestLine = currLine;
                    longestCount = 1;
                }
                else if(longestLine==currLine)
                {
                    longestCount++;
                }
                    currLine = 0;
            }
        }
        for (int j = 0; j < num; j++)
        {
            int currLine = 0;
            for (int i = 0; i < num; i++)
            {
                while (i < num && matrix[i, j] == 1)
                {
                    currLine++;
                    i++;
                }
                if (currLine > longestLine)
                {
                    longestLine = currLine;
                    longestCount = 1;
                }
                else if (longestLine == currLine)
                {
                    longestCount++;
                }
                currLine = 0;
            }
        }
        if(longestLine==1)
        {
            longestCount /= 2 ;
        }
        Console.WriteLine(longestLine);
        Console.WriteLine(longestCount);
    }
}

