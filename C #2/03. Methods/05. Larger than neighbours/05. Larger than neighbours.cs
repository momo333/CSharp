using System;

class LargerThanNeighbours
{
    static bool IsLargerThanNeighbours(int[] array, int index)
    {
        bool checkElement = false;
        for (int i = 0; i <array.Length; i++)
        {
            if(array[index]> array[index +1] && array[index]> array[index -1])
            {
                checkElement=true;
                return checkElement;
            }
            else 
            return checkElement;
        }
        return checkElement;
    }
    static void Main()
    {
        //•	Write a method that checks if the element at given position in given array of integers is larger than 
        //  its two neighbours (when such exist).
        Console.WriteLine("Please input number elements for the array");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input index of the number that will be checked [0, {0}]", size - 1);
        int index = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        if(IsLargerThanNeighbours(array, index))
        {
            Console.WriteLine("The number is bigger than it's neighbours");
        }
        else
            Console.WriteLine("The number is not bigger than it's neighbours");
    }
}

