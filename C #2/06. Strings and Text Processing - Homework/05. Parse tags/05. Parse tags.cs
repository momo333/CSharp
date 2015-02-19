using System;
using System.Linq;
using System.Text.RegularExpressions;
//•	You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and</upcase> to upper-case.
//•	The tags cannot be nested.
class ParseTags
{
    static void Main()
    {
        //string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string input = Console.ReadLine();
        string modificate = Regex.Replace(input, @"<upcase>([\w\s]*)</upcase>", match => match.Groups[1].Value.ToUpper());
        Console.WriteLine(modificate);
        

    }
}

