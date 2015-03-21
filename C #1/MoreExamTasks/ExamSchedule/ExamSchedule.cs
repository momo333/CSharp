using System;

class Program
{
    public static string StrHour(int hour)
    {
        string finalHour = " ";
        if (hour < 10)
        {
            finalHour = "0" + hour;
            return finalHour;
        }
        else
            finalHour = hour.ToString();
            return finalHour;
    }
    public static string StrMin(int min)
    {
        string finalMin = " ";
        if (min < 10)
        {
            finalMin = "0" + min;
            return finalMin;
        }
        else
            finalMin = min.ToString();
            return finalMin ;
    }
    static void Main(string[] args)
    {
        int hour = int.Parse(Console.ReadLine());
        int mins = int.Parse(Console.ReadLine());
        string timeFormat = Console.ReadLine();
        int endHour = int.Parse(Console.ReadLine());
        int endMin = int.Parse(Console.ReadLine());

        int endH = hour + endHour;
        if(endH>=12)
        {
            endH -= 12;
            if(timeFormat=="AM")
            {
                timeFormat="PM";
            }
            else
                timeFormat="AM";
        }
        int endmin = mins + endMin;
        if(endmin>59)
        {
            endmin -= 60;
            endH++;
        }
        if (endH >= 12)
        {
            if (timeFormat == "AM")
            {
                timeFormat = "PM";
            }
            else
                timeFormat = "AM";
        }
        Console.WriteLine("{0}:{1}:{2}", StrHour(endH), StrMin(endmin), timeFormat);
    }
}

