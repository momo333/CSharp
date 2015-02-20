using System;
//Problem 21.* Combinations of set

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].

class CombinationsOfSet
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());
    static void Combinations(int[] array, int index, int number)   //generates variations
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = number; i <= n; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i + 1);
            }
        }
    }
    static void PrintArray(int[] array)      //Print Array
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] array = new int[k];
        Combinations(array, 0, 1);
    }
}

