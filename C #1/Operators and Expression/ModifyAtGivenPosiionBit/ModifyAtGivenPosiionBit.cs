using System;
//Problem 14. Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an Integer Number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit's position:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value:");
        int v = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(n, 2).PadLeft(16, '0');
        Console.WriteLine("The binary representation of the {0} is:\n{1}", n, binary);
        int mask = 1 << p;
        if (v == 0)
        {
            n = n & (~mask);
            string binaryResult = Convert.ToString(n, 2).PadLeft(16, '0');
            Console.WriteLine("Binary result is:\n{0}\nand now has value of: {1}", binaryResult, n);
        }
        else
        {
            n = n | mask;
            string binaryResult = Convert.ToString(n, 2).PadLeft(16, '0');
            Console.WriteLine("Binary result is:\n{0}\nand now has value of: {1}", binaryResult, n);
        }
    }
}

