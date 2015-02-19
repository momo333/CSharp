using System;

class ReverseNumber
{
     static int ReverseInt(int num)
    {
        int result = 0;
        while (num > 0)
        {
            result = result * 10 + num % 10;
            num /= 10;
        }
        return result;
    }
    static void Main()
    {
        //•	Write a method that reverses the digits of given decimal number.
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int rev = ReverseInt(number);
        Console.WriteLine("The reversed number is: {0}", rev);
    }
}

