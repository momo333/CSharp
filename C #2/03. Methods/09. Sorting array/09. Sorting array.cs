using System;
/*•	Write a method that return the maximal element in a portion of array of integers starting 
         *  at given index.
          •	Using it write another method that sorts an array in ascending / descending order.*/

class SortingArray
{
    static private int BiggestNumberInPartOfArray(int[] array, int index)
    {
        int length = array.Length;
        int biggestNum = array[index];

        for (int i = index; i < length; i++)
        {
            if (array[i] > biggestNum)
            {
                biggestNum = array[i];
            }
        }
        return biggestNum;
    }
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int index = int.Parse(Console.ReadLine());
        if(index>=size)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int biggestNumInInterval = BiggestNumberInPartOfArray(array, index);
        
        Console.WriteLine("The biggest numbers is: {0}", biggestNumInInterval);
    }
}
