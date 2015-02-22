using System;
//Problem 11. Random Numbers in Given Range
//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

class RandomizeNumbersFromOneToN
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        for (int index = 0; index < number; index++)
        {
            array[index] = index + 1;
        }
 
        Random random = new Random();
        foreach (int index in array)
        {
            int randNum = random.Next(0, number);
            int temp = array[randNum];
            array[randNum] = array[0];
            array[0] = temp;
        }
        Console.WriteLine(String.Join(" ", array));
    }
}

