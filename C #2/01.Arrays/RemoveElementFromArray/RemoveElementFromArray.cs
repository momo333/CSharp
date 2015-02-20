using System;
using System.Collections.Generic;
using System.Linq;
//Problem 18.* Remove elements from array
//Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.

class RemoveElementFromArray
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
    }
}

