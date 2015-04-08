using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class LongString
    {
        public static int longestString = 0;
        static void Main(string[] args)
        {
            int size = 50;
            var strings = GenerateArray(size);
            var longest = strings.OrderByDescending(s => s.Length)
                   .ThenBy(s => s)
                   .FirstOrDefault();
            Console.WriteLine(longest);

        }

        private static List<string> GenerateArray(int size)
        {
            List<string> arrayOfStrings = new List<string>();
            Random rand = new Random();
            string word = "";
            for (int i = 0; i < 50; i++)
            {
                word = new string((char)rand.Next(65, 91), rand.Next(1, 50));
                arrayOfStrings.Add(word);
            }
            return arrayOfStrings;
        }
    }
}
