using System;
//Problem 14. Quick sort
//Write a program that sorts an array of strings using the Quick sort algorithm.

class Program
    {
        static void Main(string[] args)
        {
            // Create an unsorted array of string elements
            int number = int.Parse(Console.ReadLine());
            int[] unsorted  = new int[number];

            for (int i = 0; i < unsorted.Length; i++)
            {
                unsorted[i] = int.Parse(Console.ReadLine());
            }
            // Print the unsorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write("{0} ", unsorted[i]);
            }
 
            Console.WriteLine();
            int length = unsorted.Length;
            // Sort the array
            Quicksort(unsorted, 0, length - 1);
 
            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }
            Console.WriteLine();
        }
        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];
 
            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
 
                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;
                    i++;
                    j--;
                }
            }
            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }
            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
 
    }
