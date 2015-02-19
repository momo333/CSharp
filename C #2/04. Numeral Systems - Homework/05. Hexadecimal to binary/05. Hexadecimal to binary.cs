using System;
//•	Write a program to convert hexadecimal numbers to their decimal representation.
class HexadecimalToBinary
{
    static string hex2binary(string hexvalue)
    {
        string binaryval = "";
        binaryval = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
        return binaryval;
    }
    static void Main()
    {
        string hexadecimal = Console.ReadLine();
        string binary = hex2binary(hexadecimal);
        Console.WriteLine(binary);
    }
}

