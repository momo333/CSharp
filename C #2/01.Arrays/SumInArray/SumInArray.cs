using System;
using System.Text;
using System.Linq;
//Problem 10. Find sum in array
//Write a program that finds in given array of integers a sequence of given sum S (if present).

class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int s = int.Parse(Console.ReadLine());
        int sum = 0;
        int ind = 0;
        for (int j = 0; j < size; j++)
        {
            sum += arr[j];
            if (sum < s)
            {
                if (j < size - 1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("No");
                    break;
                }
            }
            else
            {
                while (sum > s)
                {
                    sum = sum - arr[ind];
                    ind++;
                }
            }
            if (sum == s)
            {
                for (int k = ind; k <= j; k++)
                {
                    Console.WriteLine(arr[k]);
                }
                break;
            }
            else if ((sum < s) && (j == size - 1))
            {
                Console.WriteLine("No");
                break;
            }
        }
    }
}
