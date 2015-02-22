using System;
using System.Text.RegularExpressions;
/*•	Write a program that parses an URL address given in the format:
         * [protocol]://[server]/[resource] and extracts from it the [protocol],
         * [server] and [resource] elements.*/
class ParseURL 
{
    static void Main()
    {
        Console.Write("Enter URL adress:");
        string urlInput = Console.ReadLine();
        string regex = @"(?<protocol>^(ht|f)tp(s?))\:\/\/(?<server>(?:www\.)?[a-zA-Z0-9\.]+\.[a-z]{2,4})(?<resource>.*)";

        if (Regex.IsMatch(urlInput, regex))
        {
            MatchCollection collection = Regex.Matches(urlInput, regex);
            foreach (Match match in collection)
            {
                Console.WriteLine("Protocol: {0} ", match.Groups["protocol"].Value);
                Console.WriteLine("Server:   {0}", match.Groups["server"].Value);
                Console.WriteLine("Resource: {0}", match.Groups["resource"].Value);
            }
        }
        else
        {
            Console.WriteLine("Invalid URL Adress!");
        }
    }
}
