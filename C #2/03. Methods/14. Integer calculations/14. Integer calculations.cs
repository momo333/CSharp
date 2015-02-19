using System;
//•	Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//•	Use variable number of arguments.

class IntegerCalculations
{
    static void MinValue(int[] array)
    {
        int minValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i]<minValue)
            {
                minValue = array[i];
            }
        }
        Console.WriteLine("The minium vaue of the sequence is: {0}", minValue);
    }
    static void MaxValue(int[] array)
    {
        int maxValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }
        Console.WriteLine("The maxium vaue of the sequence is: {0}", maxValue);
    }
    static void AverageValue(int[] array)
    {
        int sum = 0;
        int length = array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double average = (double)sum / length;
        Console.WriteLine("The average vaue of the sequence is: {0}", average);
    }
    static void Sum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("The sum of the members of the sequence is: {0}", sum);
    }
    static void Product(int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        Console.WriteLine("The product of the members of the sequence is: {0}", product);
    }

    static void Main()
    {
        Console.WriteLine("Please enter number values of the sequence: ");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the values: ");
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please choose a option: ");
        Console.WriteLine("1. Find the minimum vaue of sequence: ");
        Console.WriteLine("2. Find the maximum value of the sequence: ");
        Console.WriteLine("3. Find the average value of sequnce of numbers: ");
        Console.WriteLine("4. Find the sum of the values of sequence: ");
        Console.WriteLine("5. Find the product of the numbers of sequence");
        string option = Console.ReadLine();
        switch(option)
        {
            case "1":
                MinValue(array); break;
            case "2": 
                MaxValue(array); break;
            case"3":
                AverageValue(array); break;
            case "4":
                Sum(array); break;
            case "5":
                Product(array); break;
            default:
                Console.WriteLine("Invalid input, please enter a number between 1 and 5");
                break;

        }
    }
}

