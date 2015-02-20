using System;

class GetLargestNumber
{
    static void GetMax(int one, int two)
    {
        if (one > two)
        {
            Console.WriteLine(one); ;
        }
        else if (two > one)
        {
            Console.WriteLine(two); ;
        }
        else              // the numbers are equal, print the first number
            Console.WriteLine(one); 
    }
    static void Main()
    {
        /*•	Write a method GetMax() with two parameters that returns the larger of two integers.
          •	Write a program that reads 3 integers from the console and prints the largest of 
         * them using the method GetMax(). */
        int paramOne = int.Parse(Console.ReadLine());
        int paramTwo = int.Parse(Console.ReadLine());
        
    }
}

