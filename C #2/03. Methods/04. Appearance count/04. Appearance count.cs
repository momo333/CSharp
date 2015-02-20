using System;

class AppearanceCount
{
    static int CountOcuurence(int[] array, int number)
    {
        int count =0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i]==number)
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        //•	Write a method that counts how many times given number appears in given array.
        //•	Write a test program to check if the method is workings correctly.
        int number = int.Parse(Console.ReadLine());
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int occurrence = CountOcuurence(array, number);
        Console.WriteLine("The number arrears {0} times int the array",occurrence);
    }
}
