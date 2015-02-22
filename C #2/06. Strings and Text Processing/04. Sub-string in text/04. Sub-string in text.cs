using System;
using System.Text.RegularExpressions;
 //• Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
class SubStringInText
{
    static void Main()
    {
        string input = Console.ReadLine();
        int regex = Regex.Matches(input, "in", RegexOptions.IgnoreCase).Count;
        Console.WriteLine(regex);
    }
}

