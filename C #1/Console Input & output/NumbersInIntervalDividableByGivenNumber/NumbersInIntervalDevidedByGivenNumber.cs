using System;
//Problem 11.* Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

class NumbersDividableGivenNumber
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b= int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers devidable by 5 without remainder from {0} to {1} are: ", a, b);
        int count = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
                count++;
        }

        Console.WriteLine(count);
    }
}