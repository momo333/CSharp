using System;
 /*•Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
  * percentage and in scientific notation.
  •	Format the output aligned right in 15 symbols.*/
class FormatNumber
{
    static void Main()
    {
       double number= double.Parse(Console.ReadLine());
        Console.WriteLine("{0,15}:Decimal", number);
        Console.WriteLine("{0,15:X}:Hex", (int)number);
        Console.WriteLine("{0,15:P}:Percent", number);
        Console.WriteLine("{0,15:E}:Scientific Notation", number);
    }
}

