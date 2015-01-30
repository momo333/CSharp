using System;
using System.Linq;
//Problem 6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements.
class Program
{
    static void Main()
    {
        Console.WriteLine("The program finds the biggest of five numbers or more");
        double numberOne = int.Parse(Console.ReadLine());
        double numberTwo = int.Parse(Console.ReadLine());
        double numberThree = int.Parse(Console.ReadLine());
        double numberFour = int.Parse(Console.ReadLine());
        double numberFive = int.Parse(Console.ReadLine());


        double[] numbers= {numberOne, numberTwo, numberThree, numberFour, numberFive};
        double biggestNumber = numbers.Max();
        Console.WriteLine("The biggest number is: {0}", biggestNumber);
    }
    }
  

