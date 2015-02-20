using System;
//Problem 16.* Subset with sum S
//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.

class Program
{
    static void Main(string[] args)
    {
        int sum = int.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int count = (int)Math.Pow(2, number);
        for (int i = 0; i <count; i++)
        {
            int s = 0;
            int bitsTurn = i;
            for (int j = 0; j < number; j++)
            {
                if(bitsTurn%2==1)
                {
                    sum += array[i];
                }
                bitsTurn = bitsTurn >> 1;
            }
            if(s==sum)
            {

            }
        }
    }
}

