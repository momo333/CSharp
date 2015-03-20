using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Zerg
{
    class Zerg
    {
        static void Main(string[] args)
        {
            string[] alpha = { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr",
                                 "Mrrr", "Psst", "Uaah", "Uaha",  "Zzzz",
                                 "Bauu", "Djav",  "Myau", "Gruh" };
            var input = Console.ReadLine();
            var currLetter = new StringBuilder();
            BigInteger result = 0;
            foreach (var c in input)
            {
                currLetter.Append(c);
                if (alpha.Contains(currLetter.ToString()))
                {
                    int currDigit = Array.IndexOf(alpha, currLetter.ToString());
                    result *= 15;
                    result += currDigit;
                    currLetter.Clear();
                }
            }
            Console.WriteLine(result);
        }
    }
}
