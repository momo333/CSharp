using System;


class Program
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year= int.Parse(Console.ReadLine());

        DateTime currentdate = new DateTime(year, month, day);
       currentdate= currentdate.AddDays(1);
       Console.WriteLine(currentdate.Day + "." + currentdate.Month + "." + currentdate.Year);
    }
}
