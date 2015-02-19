using System;

//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//Submit the source code of your Visual Studio project as part of your homework submission.



class Declare
{
    static void Main()
    {
        byte a = 97;
        sbyte b = -115;
        ushort c = 52130;
        short d = -10000;
        int e = 4825932;
        Console.WriteLine("The first number is using byte {0}, second is sbyte {1}, third is ushort {2}, fourth is short {3} and fifth is int {4}", a, b, c, d, e);
    }
}