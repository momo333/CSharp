﻿/* Write a program that finds the sequence of maximal sum in given array. Example:
        {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
        Can you do it with only one loop (with single scan through the elements of the array)?
 */

using System;
using System.Text;

class MaxSequence
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] myArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }
        int currentSum = 0;
        int bestSum = int.MinValue;
        StringBuilder bestSequenceBuild = new StringBuilder();
        string bestSequnce = "";
        for (int i = 0; i < myArray.Length; i++)
        {
            currentSum = currentSum + myArray[i];
            bestSequenceBuild.AppendFormat("{0}, ", myArray[i]);
            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestSequnce = bestSequenceBuild.ToString();
            }
            if (currentSum < 0)
            {
                currentSum = 0;
                bestSequenceBuild.Clear();
            }
        }
        Console.WriteLine("The best sequence is: \" {0} \" ", bestSequnce);
        Console.WriteLine("The best sum is: {0} ", bestSum);
    }
}