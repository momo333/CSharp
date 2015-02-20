using System;
//Problem 15. Prime numbers
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

class Program
{
    static void Main(string[] args)
    {
        int number = 100000000;
        int[] primeNumbers = new int[number];
        for (int i = 0; i < number; i++)
        {
            primeNumbers[i] = i + 1;
        }
        for (int i = 1; i < number; i++)
        {
            if(primeNumbers[i]>0)
            {
                for (int j = 2; j < primeNumbers.Length/(i+1); j++)
                {
                    primeNumbers[(j * (i + 1)) - 1] = 0;
                }
            }
        }
        for (int i = 0; i < number; i++)
        {
           if(primeNumbers[i]!=0)
           {
               Console.Write("{0} ", primeNumbers[i]);
           }
        }
    }
}

