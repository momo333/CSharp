using System;
//•	Write a program to convert binary numbers to hexadecimal numbers (directly).
class BinaryToHexadecimal
{
    static string HexConverted(string strBinary)
    {
        string strHex = Convert.ToInt32(strBinary, 2).ToString("X");
        return strHex;
    }
    static void Main()
    {
        Console.WriteLine("Please enter number in binary repreentation: ");
        string binary = Console.ReadLine();
        string hex = HexConverted(binary);
        Console.WriteLine("The number in hexadecimal representation is: {0}", hex);
    }
}

 