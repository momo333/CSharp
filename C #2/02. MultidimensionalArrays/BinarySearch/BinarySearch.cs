using System;
using System.Linq;
//Problem 4. Binary search
//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
class Program
{
   
    static void Main(string[] args)
    {
        int numN = int.Parse(Console.ReadLine());
        int numK = int.Parse(Console.ReadLine());
        int[] array = new int[numN];

        for (int i = 0; i < numN; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        Console.WriteLine();
        for (int i = 0; i < numN; i++)
        {
            Console.Write("{0,2} ", i);
        }
        for (int i = 0; i < numN; i++)
        {
            Console.Write("{0,} ", array[i]);
        }
        int index = Array.BinarySearch(array, numN);
        if(index==-1)
        {
            Console.WriteLine("The searched value is smaller than all of the elements");
        }
        else if(index<-1)
        {
            int searchedIndex = (-1 * index) - 1;
        }
        else if(index>=0)
        {
            Console.WriteLine("Number {0} with index {1} ", array[index],index);
        }

    }
}

