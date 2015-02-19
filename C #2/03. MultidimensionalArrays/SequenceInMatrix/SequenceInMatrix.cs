using System;
//Problem 3. Sequence n matrix
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

class SequenceInMatrix
{
    static void Main(string[] args)
    {
        string[,] strings = {
            {"ha", "fifi", "ho", "hi"},
            {"fo", "ha", "hi", "xx"},
            {"xxx", "ho", "ha", "xx"}
        };
        int sequence = 1;
        int bestSeq = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        string element = "";
        string direction = "";
        for (int row = 0; row < strings.GetLength(0); row++)
        {
            for (int col = 0; col < strings.GetLength(1) - 1; col++)
            {
                if (strings[row, col] == strings[row, col + 1])
                {
                    sequence++;
                    element = strings[row,row];
                }
                else
                {
                    sequence = 1;
                }
                if (sequence > bestSeq)
                {
                    bestSeq = sequence;
                    bestRow = row;
                    bestCol = col;
                    direction = "Horizontal";
                }
            }
            sequence = 1;
        }
        for (int col = 0; col < strings.GetLength(1); col++)
        {
            for (int row = 0; row < strings.GetLength(0) - 1; row++)
            {
                if (strings[row, col] == strings[row + 1, col])
                {
                    sequence++;
                    element = strings[row, col];
                }
                else
                {
                    sequence = 1;
                }
                if (sequence > bestSeq)
                {
                    bestSeq = sequence;
                    bestRow = row;
                    bestCol = col;
                    direction = "Horizontal";
                }
            }
            sequence = 1;
        }
        for (int m = 0; m < strings.GetLength(0) - 1; m++)
        {
            for (int n = 0; n < strings.GetLength(1) - 1; n++)
            {
                for (int row = m, col = n; row < strings.GetLength(0) - 1 && col < strings.GetLength(1) - 1; row++, col++)
                {
                    if (strings[row, col] == strings[row + 1, col + 1])
                    {
                        sequence++;
                        element = strings[row, col];
                    }
                    else
                    {
                        sequence = 1;
                    }
                    if (sequence > bestSeq)
                    {
                        bestSeq = sequence;
                        bestRow = row + 1;
                        bestCol = col + 1;
                        direction = "Maindiagonal";
                    }
                }
                sequence = 1;
            }
        }
        for (int m = 0; m < strings.GetLength(0) - 1; m++)
        {
            for (int n = 1; n < strings.GetLength(1) - 1; n++)
            {
                for (int row = m, col = n; row < strings.GetLength(0) - 1 && col > strings.GetLength(1) - 1; row++, col++)
                {
                    if (strings[row, col] == strings[row + 1, col - 1])
                    {
                        sequence++;
                        element = strings[row, row];
                    }
                    else
                    {
                        sequence = 1;
                    }
                    if (sequence > bestSeq)
                    {
                        bestSeq = sequence;
                        bestRow = row + 1;
                        bestCol = col - 1;
                        direction = "Secondarydiagonal";
                    }
                }
                sequence = 1;
            }
        }
        Console.WriteLine(direction);
        for (int i = 0; i < sequence-1; i++)
        {
            Console.Write("{0},",element);
            Console.Write(element);
        }
    }
}