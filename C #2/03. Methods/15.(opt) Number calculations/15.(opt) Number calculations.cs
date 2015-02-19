using System;
using System.Collections.Generic;
using System.Collections;
/*•	Modify your last program and try to make it work for any number type, not just integer 
        * (e.g. decimal, float, byte, etc.)
         •	Use generic method (read in Internet about generic methods in C#).*/
class NumberCalculations
{
    class IntegerCalculations
    {
        static T MinValue<T>(params T[] array)
        {
            dynamic minValue = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }
        static T MaxValue<T>(params T[] array)
        {
            dynamic maxValue = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        static T AverageValue<T>(params T[] array)
        {
            dynamic sum = 0;
            int length = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            dynamic average = (double)sum / length;
            return average;
        }
        static T Sum<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static Т Product<Т>(params T[] array)
        {
            dynamic product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }

        static void Main()
        {

            Console.WriteLine("Please choose a option: ");
            Console.WriteLine("1. Find the minimum vaue of sequence: ");
            Console.WriteLine("2. Find the maximum value of the sequence: ");
            Console.WriteLine("3. Find the average value of sequnce of numbers: ");
            Console.WriteLine("4. Find the sum of the values of sequence: ");
            Console.WriteLine("5. Find the product of the numbers of sequence");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("The minimal value is: {0}", MinValue(1, 2, 3, 4, 5));
                    break;
                case "2":
                    Console.WriteLine("The maximum value is: {0}", MaxValue(1, 2, 3, 4, 5));
                    break;
                case "3":
                    Console.WriteLine("The average value is: {0}",AverageValue(1.0, 2, 3, 4, 5));
                    break;
                case "4":
                    Console.WriteLine("The sum of values is: {0}",Sum(1, 2, 3, 4, 5));
                    break;
                case "5":
                    Console.WriteLine("The product of the numbers is: {0}", Product(1, 2, 3, 4, 5));
                    break;
                default:
                    Console.WriteLine("Invalid input, please enter a number between 1 and 5");
                    break;
            }
        }
    }


}

