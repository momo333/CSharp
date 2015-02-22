using System;
using System.Text;
using System.Collections.Generic;
//•	Write a program that reads a string from the console and replaces all series 
//  of consecutive identical letters with a single one.
class SeriesOfLetters
{
    static void Main()
    {
        string text = Console.ReadLine();
        StringBuilder textNew = new StringBuilder();
        char letter = text[0];
        textNew.Append(text[0]);
        int lenghth=text.Length;
        for (int i = 0; i <lenghth; i++)
        {
            if(letter!=text[i])
            {
                textNew.Append(text[i]);
                letter = text[i];
            }
        }
        textNew.ToString();
        Console.WriteLine(textNew);
    }
}

