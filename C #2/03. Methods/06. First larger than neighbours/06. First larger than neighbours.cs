using System;

class FirstLargerThanNeighbours
{
    static int GetIndexOfElementBiggerThanNeighBours(int[] arr)
    {
        int index = -1;
        for (int i = 1; i < arr.Length-1; i++)
        {
            if(arr[i]>arr[i-1] && arr[i]>arr[i-1])
            {
                index = i;
                return index;
            }
        }
        return index;
    }
    static void Main()
    {
        /*•	Write a method that returns the index of the first element in array that is larger than
         *  its neighbours, or -1, if there’s no such element.
          •	Use the method from the previous exercise.*/
        Console.WriteLine("Please input number elements for the array");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The first index bigger then it's neighbours is: {0}",GetIndexOfElementBiggerThanNeighBours(array));
    }
}



   