﻿using System;
using System.Text;

//Problem 14.* Print the ASCII Table
//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
//Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
//Note: You may need to use for-loops (learn in Internet how).

class AsciiTableOfSymbols
{
    static void Main()
    {
        for (int i = 0; i <= 255; i++)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("{0}->{1}", i, (char)i);
            if (char.IsDigit((char)i))
            {
                Console.WriteLine("{0}->{1}", i, (char)i);   //If the symbols are not printed correctly change the console font
            }
        }
    }
}
