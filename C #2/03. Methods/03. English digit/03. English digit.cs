﻿using System;

class EnglishDigit
{
    static string GetWord(int number)
    {
        string word = "";
        int digit = number % 10;
        switch(digit)
        {
            case 0: word = "zero"; break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
        }
        return word;
    }
    static void Main()
    {
        //•	Write a method that returns the last digit of given integer as an English word.
        int number = int.Parse(Console.ReadLine());
        string word = GetWord(number);
        Console.WriteLine(word);

    }
}

