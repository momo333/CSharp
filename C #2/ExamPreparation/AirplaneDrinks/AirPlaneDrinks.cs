using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneDrinks
{
    class AirPlaneDrinks
    {
        static long Solve(long numberSeat, long[] tea)
        {
            long result = numberSeat * 4;
            bool[] isServe = new bool[numberSeat];
            for (int i = 0; i < tea.Length; i++)
            {
                isServe[tea[i] - 1] = true;
            }
            long lastt = 0;
            long lastc = 0;
            long countt = 0;
            long countc = 0;
            for (long i = numberSeat - 1; i >= 0; i--)
            {
                if (isServe[i])
                {
                    countt++;
                    lastt = Math.Max(lastt, i + 1);
                }
                else
                {
                    countc++;
                    lastc = Math.Max(lastc, i + 1);
                }
                if (countc == 7)
                {
                    countc = 0;
                    result += lastc * 2;
                    result += 47; 
                    lastc = 0;
                }
                if (countt == 7)
                {
                    countt = 0;
                    result += lastt * 2;
                    result += 47; 
                    lastt = 0;
                }
            }
            if (countc != 0)
            {
                result += lastc * 2;
                result += 47;
            }
            if (countt != 0)
            {
                result += lastt * 2;
                result += 47;
            }
            return result;
        }
        static void Main(string[] args)
        {
            long numberSeats = long.Parse(Console.ReadLine());
            long size = long.Parse(Console.ReadLine());
            long[] teaArray = new long[size];

            for (int i = 0; i < size; i++)
            {
                teaArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(Solve(numberSeats, teaArray));
        }
    }
}
