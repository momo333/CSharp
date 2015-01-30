using System;
//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());
        int result = CheckPrime(number);
        if (number <= 100)
        {
            if (result == 0)
            {
                Console.WriteLine("True");
            }
            else if (result == 1)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.Read();
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
    private static int CheckPrime(int number)
    {
        int i;
        for (i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return 0;
            }
        }
        if (i == number)
        {
            return 1;
        }
        return 0;
    }
}
