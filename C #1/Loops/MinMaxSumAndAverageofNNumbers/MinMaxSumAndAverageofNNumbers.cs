using System;
//Problem 3. Min, Max, Sum and Average of N Numbers
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

class Program
{
    static void Main(string[] args)
    {
        int number=int.Parse(Console.ReadLine());
        int min=Int32.MaxValue;
        int max = Int32.MinValue;
        int sum =0;
        double avg =0;
        for (int i = 0; i < number; i++)
			{
			int num = int.Parse(Console.ReadLine());
            sum+=num;
            if(min>num)
            {
                min=num;
            }
            if(max<num)
            {
                max=num;
            }
			}
         Console.WriteLine("min = {0}", min);
         Console.WriteLine("max = {0}", max);
         Console.WriteLine("sum = {0}", sum);
         Console.WriteLine("avg = {0:F2}", sum/(double)number);

    }
}

