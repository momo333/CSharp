using System;

//Problem 15. Hexadecimal to Decimal Number
//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

class DecimalToHexadecimalNumber
{
static void Main()
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            string hexNumber = "";
            if (decimalNumber == 0)
            {
                hexNumber = "0";
            }
            else
            {
                while (decimalNumber > 0)
                {
                    long remain = decimalNumber % 16;
                    decimalNumber /= 16;
                    switch (remain)
                    {
                        case 10: hexNumber = "A" + hexNumber; break;
                        case 11: hexNumber = "B" + hexNumber; break;
                        case 12: hexNumber = "C" + hexNumber; break;
                        case 13: hexNumber = "D" + hexNumber; break;
                        case 14: hexNumber = "E" + hexNumber; break;
                        case 15: hexNumber = "F" + hexNumber; break;
                        default: hexNumber = remain + hexNumber; break;
                    }
                }
            }
            Console.WriteLine(hexNumber);
        }
}