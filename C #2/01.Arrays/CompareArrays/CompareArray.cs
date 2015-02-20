using System;
//Problem 2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.
class CompareArray
{
    static void Main(string[] args)
    {
        //For arrays with equal size
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int[] arrayOne = new int[numberOne];
        int[] arrayTwo = new int[numberTwo];
        bool areEqual = false;
        if (numberOne != numberTwo)
        {
            Console.WriteLine("The arrays are different!");
        }
        else
        {
            Console.WriteLine("Enter numbers for arrays: ");
            for (int i = 0; i < numberOne; i++)
            {
                arrayOne[i] = int.Parse(Console.ReadLine());
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numberTwo; i++)
            {
                if (arrayTwo[i] != arrayTwo[i])
                {
                    break;
                }
                else
                    areEqual = true;
            }
        }
        if(areEqual)
        {
            Console.WriteLine("The arrays are equal!");
        }
        else
            Console.WriteLine("The arrays are not equal!");
    }
}

