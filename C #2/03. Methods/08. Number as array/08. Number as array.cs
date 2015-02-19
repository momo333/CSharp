using System;
//•	Write a method that adds two positive integer numbers represented as arrays of digits 
        //  (each array element arr[i]contains a digit; the last digit is kept in arr[0]).
        //•	Each of the numbers that will be added could have up to 10 000 digits.
class NumberAsArray
{
    static double SumOfNumbers(string first, string second)
    {
        double numOne = 0;
        double numTwo = 0;
        int length = first.Length;
        for (int i = 0; i < first.Length; i++)
        {
            double partial = ((int)(first[i] - '0')) * (Math.Pow(10, first.Length- 1-i));
            numOne += partial;
        }
        for (int i = 0; i < second.Length; i++)
        {
            double partial = ((int)(second[i] - '0')) * (Math.Pow(10, second.Length - 1 -i));
            numTwo += partial;
        }
        double sumNumbers =(numOne + numTwo);
        return sumNumbers;
    }
    static void Main()
    {
        
        string firtNum = Console.ReadLine();
        string secNum = Console.ReadLine();
        double sumNumbers = SumOfNumbers(firtNum, secNum);

        Console.WriteLine("The sum of the numbers is {0}", sumNumbers);
    }
}

