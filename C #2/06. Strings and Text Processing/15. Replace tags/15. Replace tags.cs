using System;
using System.Text.RegularExpressions;
//•	Write a program that replaces in a HTML document given as string all the tags
 //  <a href="…">…</a> with corresponding tags [URL=…]…/URL]
class ReplaceTags
{
    static void Main()
    {
        string text = Console.ReadLine();

        string replaceText = Regex.Replace(text, @"< href= """, "URL=");
        replaceText = Regex.Replace(replaceText, @""">", "] ");
        replaceText = Regex.Replace(replaceText, @"</a>", "[/URL]");
        Console.WriteLine(replaceText);
    }
}

