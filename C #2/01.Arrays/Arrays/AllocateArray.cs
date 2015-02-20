using System;
//Problem 1. Allocate array
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console

class Program
{
    static void Main(string[] args)
    {
        int size = 20;
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = i * 5;
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

