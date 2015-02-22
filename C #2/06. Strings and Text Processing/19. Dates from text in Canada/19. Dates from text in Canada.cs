using System;
using System.Text.RegularExpressions;
using System.Globalization;
/*•	Write a program that extracts from a given text all dates that match the 
 * format DD.MM.YYYY.
•	Display them in the standard date format for Canada.*/

class DatesFromTextInCanada
{
    static void Main()
    {
        string text = Console.ReadLine();
        string regex = @"\d{1,2}\.\d{1,2}\.\d{4}";
        MatchCollection dates = Regex.Matches(text, regex);
        var provider = new CultureInfo("en-CA", false);
        foreach(Match date in dates)
        {
            DateTime dateNew;
            DateTime.TryParse(date.ToString(), out dateNew);
            Console.WriteLine(dateNew.ToString("dd/MM/yyyy",provider));
        }
    }
}