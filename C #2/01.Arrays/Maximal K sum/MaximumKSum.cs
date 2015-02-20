using System;
//Problem 6. Maximal K sum
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
class MaximumKSum
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        for (int i = N-1; i>=N-K; i--)
        {
            
            Console.WriteLine(arr[i]);
            sum += arr[i];
        }
        Console.WriteLine("The maximal sum is: {0}", sum);
    }
}

