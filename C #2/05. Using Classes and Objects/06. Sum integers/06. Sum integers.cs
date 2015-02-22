using System;
//•	You are given a sequence of positive integer values written into a string, separated by spaces.
        //•	Write a function that reads these values from given string and calculates their sum.
class SumIntegers
{
    static int StringToSum(string str)
    {
        int sum = 0;
        str = str.Trim();
        string[] nums = str.Split(' ');
        for (int i = 0; i < nums.Length; i++)
        {
            sum += int.Parse(nums[i]);
        }
        return sum;
    }
    static void Main()
    {
        string str = Console.ReadLine();
        Console.WriteLine(StringToSum(str));


    }
}

