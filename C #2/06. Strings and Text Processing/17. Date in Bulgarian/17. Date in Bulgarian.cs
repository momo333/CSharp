using System;
using System.Globalization;
/*•	Write a program that reads a date and time given in the format:
 * day.month.year hour:minute:second and prints the date and time 
 * after 6 hours and 30 minutes (in the same format) along with the 
 * day of week in Bulgarian.*/
class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Please enter a date in format: \nDay.month.year hour:minute:second");
        string dateTime = "dd.MM.yyyy HH:mm:ss";
        DateTime date = DateTime.ParseExact(Console.ReadLine(), dateTime, CultureInfo.InvariantCulture.DateTimeFormat);
        DateTime sixHoursLater = date.AddHours(6.5);
        Console.WriteLine("{0:dd.MM.yyyy HH:mm:ss}", sixHoursLater);
    }
}
