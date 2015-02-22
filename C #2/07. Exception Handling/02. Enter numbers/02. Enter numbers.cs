using System;
using System.Collections.Generic;
/*•	Write a method ReadNumber(int start, int end) that enters an integer number in a given 
         * range [start…end].
            o	If an invalid number or non-number text is entered, the method should throw an exception.
          •	Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 
         * 1 < a1 < … < a10 < 100*/

class EnterNumbers
{
    static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Please enter number in range {0} - {1}",start,end);
        int number = int.Parse(Console.ReadLine());
        try
        {
            if(number<=start || number>=end)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine("The number is valid! ");
        }
        catch(ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number is not in the range {0} - {1}", start, end);
        }
        catch(FormatException)
        {
            Console.WriteLine("Not a number! ");
        }
        catch(ArgumentException)
        {
            Console.WriteLine("Nothing is entered!");
        }
        return number;
    }
    static void Main()
    {
        int count = 10;
        int start =int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        List<int> arr = new List<int>();
        for (int i = 0; i < count; i++)
        {
            arr.Add(ReadNumber(start, end));
        }
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
