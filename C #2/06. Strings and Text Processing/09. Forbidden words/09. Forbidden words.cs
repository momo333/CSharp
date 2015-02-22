using System;
using System.Linq;
using System.Text.RegularExpressions;
 /* •	We are given a string containing a list of forbidden words and a text containing some of 
        * these words.
          •	Write a program that replaces the forbidden words with asterisks.*/
class ForbiddenWords
{
    static void Main()
    {
        string words = Console.ReadLine();
        string text = Console.ReadLine();
        string[] wordsArray = words.Split(new char[] { ',', ' ', '"' }, StringSplitOptions.RemoveEmptyEntries);

        string regex = @"\b(" + String.Join("|", wordsArray) + @")\b";
        Console.WriteLine(Regex.Replace(text, regex, (m => new String('*', m.Length)), RegexOptions.IgnoreCase));
    }
}

