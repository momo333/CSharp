using System;
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());       //1234
        int digitFour = number % 10;
        int digitThree = (number / 10) % 10;
        int digitTwo = (number / 100) % 10;
        int digitOne = number / 1000;
        int digitSum = digitOne + digitTwo + digitThree + digitFour;
        Console.WriteLine("Sum of the digits is : {0}", digitSum);
        Console.WriteLine("The reverse number is {0}{1}{2}{3}", digitFour, digitThree, digitTwo, digitOne);
        int newNumber = digitFour * 1000 + digitTwo * 100 + digitThree * 10 + digitFour;
        Console.WriteLine(newNumber);
        int exchangeDigitsNum = digitOne * 1000 + digitThree * 100 + digitTwo * 10 + digitFour;
        Console.WriteLine(exchangeDigitsNum);
    }
}

