using System;
using System.Collections.Generic;
 //•Write a program that reads a year from the console and checks whether it is a leap one.
 //•	Use System.DateTime.
class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        DateTime date = new DateTime(year);
        Console.WriteLine(DateTime.IsLeapYear(year));
    }
}

