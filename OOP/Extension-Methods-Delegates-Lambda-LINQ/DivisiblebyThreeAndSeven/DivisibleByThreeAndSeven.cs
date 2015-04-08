using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DivisiblebyThreeAndSeven
{
    class DivisibleByThreeAndSeven
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(i);
            }
            var selectNums = numbers.Where(x => x % 21 == 0);
            foreach (var num in selectNums)
            {
                Console.WriteLine(num);
            }


            //LINQ!!!
            //var numsLINQ = from number in numbers         
            //               where number % 21 == 0
            //               select number;
            //foreach (var item in numsLINQ)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
