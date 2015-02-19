using System;
using System.Text.RegularExpressions;
//•	Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
class DatesFromTextInCanada
{
    static bool IsPalindrome(string text)
    {
        int length = text.Length;
        for (int i = 0; i < length; i++)
        {
            if (text[i] != text[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
    static void Main()
    {
        string text = Console.ReadLine();
        string regex = @"\b\w+\b";
        MatchCollection matches = Regex.Matches(text, regex);
        foreach (Match match in matches)
        {
            if (IsPalindrome(text))
            {
                Console.Write("{0}, ", text);
            }
        }
    }
}

