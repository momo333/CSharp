using System;
using System.Collections.Generic;
//Problem 19.* Permutations of set

//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        permute(array, number-1, 0);
    }

    static void permute(int[] array, int n, int i)
    {

        if (i == n)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[j]);
                Console.Write(',');
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = i; j <= n; j++)
            {
                swap(array, i, j);
                permute(array, n, i + 1);
                swap(array, i, j);     //backtrack 
            }
        }
    }
    static void swap(int[] array, int a, int b)
    {

        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
}

