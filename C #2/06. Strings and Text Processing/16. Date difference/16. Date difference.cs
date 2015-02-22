using System;
using System.Globalization;
//•	Write a program that reads two dates in the format:
        //  day.month.year and calculates the number of days between them.
class DateDifference
{
    static void Main()
    {
        string format = "dd.MM.yyyy";
        DateTime dateOne = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture.DateTimeFormat);
        DateTime dateTwo = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture.DateTimeFormat);
        Console.WriteLine("The difference is: {0} days", Math.Abs((dateTwo - dateOne).Days));
    }
}

