using System;
//Problem 15.* Bits Exchange
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        UInt32 n = UInt32.Parse(Console.ReadLine());
        Console.WriteLine("Before: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        UInt32 small = n & (7 << 3);
        UInt32 large = n & (7 << 24);
        n = (n ^ (small | large)) | (large >> 21) | (small << 21);
        Console.WriteLine("After: \t{0}\nResult: {1}", Convert.ToString(n, 2).PadLeft(32, '0'), n);
    }
}

