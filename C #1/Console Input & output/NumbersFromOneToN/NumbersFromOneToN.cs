using System;
//Problem 8. Numbers from 1 to n
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
//Note: You may need to use 

class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("The program writes the numbers from 1 do N on the console");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <=n ; i++)
        {
            Console.WriteLine(i);
        }
    }
}

