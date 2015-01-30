using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Please enter birthyear: ");
        int birthyear = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter birthmonth: ");
        int birthmonth = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter birtdate: ");
        int birthday = int.Parse(Console.ReadLine());

        DateTime birthdate = new DateTime(birthyear, birthmonth, birthday);

        System.DateTime now = System.DateTime.Now;
        System.TimeSpan age = now - birthdate; 
        double ageInDays = age.TotalDays; // convert to days 
        ageInDays = ageInDays / 356;   //and convert into years 
        Console.WriteLine("You are {0:F2} years old", ageInDays);
        Console.WriteLine("After 10 years you will be {0:F2} years old.", (ageInDays + 10));
    }
}

