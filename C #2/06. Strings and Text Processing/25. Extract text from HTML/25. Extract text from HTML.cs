using System;
using System.Text.RegularExpressions;
using System.IO;
//•	Write a program that extracts from given HTML file its title (if available), 
 //  and its body text without the HTML tags.
class ExtractTextFromHTML
{
    static void Main()
    {
        string htmlTag = File.ReadAllText("../../page.html");
        string regex = "(?<=^|>)[^><]+?(?=<|$)";

        MatchCollection matches = Regex.Matches(htmlTag, regex);

        foreach (var item in matches)
        {
            Console.WriteLine(item);
        }
    }
}

