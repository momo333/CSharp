using System;


namespace PiggyBank
{
    class PiggyBank
    {
        static void Main(string[] args)
        {
            int tankPrice = int.Parse(Console.ReadLine());
            int partyDaysInMonth = int.Parse(Console.ReadLine());
            int normaldaysInMonth = 30 - partyDaysInMonth;
            int partyMoney = partyDaysInMonth * 5;
            double moneySpentPerMonth = normaldaysInMonth * 2 - partyDaysInMonth * 5;
            if (moneySpentPerMonth < 0)
            {
                Console.WriteLine("never");
            }
            else
            {
                double time = (double)tankPrice / moneySpentPerMonth;
                int resultTime = (int)Math.Ceiling(time);
                int years = resultTime / 12;
                int months = resultTime % 12;
                Console.WriteLine("{0} years, {1} months", years, months);
            }
        }
    }
}
