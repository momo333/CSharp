using System;
//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("n=");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter index p");
        int indexP = int.Parse(Console.ReadLine());
        Console.Write("n binary:");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        int moveNumberN = number >> indexP;
        int bit = moveNumberN & 1;
        Console.Write("The value of the given bit at index p is --> ");
        Console.WriteLine(Convert.ToString(bit, 2));
    }
}