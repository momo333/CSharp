using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRES4Numbers
{
    class Tres4Numbers
    {
        static void Main(string[] args)
        {
            var numSystem = 9;
            StringBuilder builder = new StringBuilder();
            var digits = new[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|",
                "SEY&", "EMY>>", "/TEL", "<<DON" };
            ulong numberInDecimal = ulong.Parse(Console.ReadLine());
            if(numberInDecimal==0)
            {
                Console.WriteLine("LON+");
            }
            while (numberInDecimal > 0)
            {
                int digitInNinth = (int)(numberInDecimal % (ulong)numSystem);
                builder.Insert(0, digits[digitInNinth]);
                numberInDecimal /= (ulong)numSystem;
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
