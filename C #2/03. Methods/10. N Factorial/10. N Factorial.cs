using System;
using System.Numerics;
  //•	Write a program to calculate n! for each n in the range [1..100].
        //Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
 
class Factorial
{
    static void Main(string[] args)
    {
        int factorialN = int.Parse(Console.ReadLine());

        BigInteger[] factorialResults = CalculationOfFactorial(factorialN);
        PrintAllResults(factorialResults);
    }

    private static BigInteger[] CalculationOfFactorial(int countOfLoops)
    {
        BigInteger[] factorialCalculations = new BigInteger[countOfLoops];
        BigInteger factorial = 1;

        for (int i = 1; i <= countOfLoops; i++)
        {
            factorialCalculations[i - 1] = factorial;

            factorial = factorial * i;
        }

        return factorialCalculations;
    }

    private static void PrintAllResults(BigInteger[] factorialResult)
    {
        for (int i = 0; i < factorialResult.Length; i++)
        {
            Console.WriteLine(factorialResult[i]);
        }
    }
}
