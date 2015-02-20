using System;
//Problem 3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter).
class CompareChharArrays
{
    static void Main(string[] args)
    {
        //For arrays with equal size
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        char[] arrayOne = new char[numberOne];
        char[] arrayTwo = new char[numberTwo];
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
                arrayOne[i] = char.Parse(Console.ReadLine());
                arrayTwo[i] = char.Parse(Console.ReadLine());
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
        if (areEqual)
        {
            Console.WriteLine("The arrays are equal!");
        }
        else
            Console.WriteLine("The arrays are not equal!");
    }
}

