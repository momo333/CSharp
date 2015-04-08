using System;
using System.Globalization;

class InvalidRangeExceptionTesting
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int pointInt;
        Console.WriteLine("Enter Point in int from {0} to {1}",start,end);

        try
        {
            pointInt = int.Parse(Console.ReadLine());
            if ((pointInt < start) || (pointInt > end))
            {
                throw new InvalidRangeException<int>("damn boy! Please consider the range!", start, end);
            }
        }
        catch (InvalidRangeException<int> e)
        {
            Console.WriteLine("Range should be [{0}...{1}]!", e.Start, e.End);
            Console.WriteLine(e.Message);
        }

        DateTime startDate = new DateTime(1880, 01, 01);
        DateTime endDate = DateTime.Now;

        DateTime dateTime;
        CultureInfo provider = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter your birthDate (Format : 06/15/2008 ) in range 01/01/1880 - NOW :) ");

        try
        {
            dateTime = DateTime.ParseExact(Console.ReadLine(), "d", provider);
            if ((dateTime < startDate) || (dateTime > endDate))
            {
                throw new InvalidRangeException<DateTime>("damn boy! Please consider the range!", startDate, endDate);
            }
        }
        catch (InvalidRangeException<DateTime> e)
        {
            Console.WriteLine("Range should be [{0}...{1}]!", e.Start, e.End);
            Console.WriteLine(e.Message);
        }
    }
}
