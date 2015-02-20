using System;
//Problem 11. Binary search
//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

class Program
{
    public static int BinarySearch(int[] arr, int low, int high, int value)
    {
        int mid;
        while (low<= high)
        {
            mid = (low + high) / 2;
            if (arr[mid] < value)//the element we search is located to the right from the mid point
            {
                low = mid + 1;
                continue;
            }
            else if (arr[mid] > value)//the element we search is located to the left from the mid point
            {
                high = mid - 1;
                continue;
            }
            //at this point low and high bound are equal and we have found the element or
            //arr[mid] is just equal to the value => we have found the searched element
            else
            {
                return mid;
            }
        }
        return -1;//value not found
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of the array: ");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter which index is searched: ");
        int number = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int searchedIndex = BinarySearch(arr, arr[0], arr[size - 1], number);
        Console.WriteLine("The index of the element that we search is: {0}", searchedIndex);
    }
}

