using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurankulakNumbers
{
    class DurankulakNumbers
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            List<string> digits = new List<string>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                digits.Add(i.ToString());
            }
            for (char i = 'a'; i < 'f'; i++)
            {
                for (char j = 'A'; j < 'Z'; j++)
                {
                    digits.Add(i.ToString() + j.ToString());
                }
            }
            string result = "";
            if (number == 0)
            {
                Console.WriteLine("A");
            }
            while (number != 0)
            {
                result = digits[(int)number % 168] + result;
                number = number / 168;
            }
            Console.WriteLine(result);
        }
    }
}
