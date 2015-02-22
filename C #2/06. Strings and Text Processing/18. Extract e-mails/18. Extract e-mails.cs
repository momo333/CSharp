using System;
using System.Text.RegularExpressions;
//•	Write a program for extracting all email addresses from given text.
//•	All sub-strings that match the format @… should be recognized as emails.
class ExtractEMails
{
    static void Main()
    {
        string text = Console.ReadLine();
        string regex = @"[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,4}";
        MatchCollection match = Regex.Matches(text, regex);
        foreach(var mail in match)
        {
            Console.WriteLine(mail);
        }

    }
}

