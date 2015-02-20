using System;
//Problem 3. Variable in Hexadecimal Format

//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
//Use Windows Calculator to find its hexadecimal representation.
//Print the variable and ensure that the result is 254.

class Program
{
    static void Main()
    {
        
        int number = 254;
        number = 0xFE;  //hexadecimal
        Console.WriteLine("Your number in hexadecimal is: {0:x}", number); 
    }
}
