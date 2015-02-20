using System;

//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int firstNum = 0;
        int len = 1;
        int bestfirstNum = 0;
        int bestLen = 1;
        for (int i = 1; i < n; i++)
        {
            if (a[i] > a[i - 1])
            {
                len++;
                if (len == 2)
                {
                    firstNum = i - 1;           //start of the increasing sequence
                }
                if (len > bestLen)
                {
                    bestLen = len;
                    bestfirstNum = firstNum;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                len = 1;
            }
        }
        for (int i = bestfirstNum; i < bestfirstNum + bestLen; i++)
        {
            Console.Write(a[i] + ' ');
        }
    }
}
