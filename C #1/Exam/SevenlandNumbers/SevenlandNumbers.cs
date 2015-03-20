using System;


namespace _01.SevenlandNumbers
{
    class Program
    {
        static void Main()
        {
            short number;

            number = short.Parse(Console.ReadLine());
            if (number % 10 == 6)
            {
                if ((number % 100 == 66) && (number % 1000 != 666))
                {
                    number += 34;
                }
                else if (number % 1000 == 666)
                {
                    number += 334;
                }
                else
                    number += 4;
            }
            else
            {
                number += 1;
            }
            Console.WriteLine(number);
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
 
//namespace SevenLand2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int k = int.Parse(Console.ReadLine());
 
//            int number = 0;
//            int counter = 0;
//            int result = 0;
 
//            do
//            {
//                number = k % 10;
//                k /= 10;
//                result += number * (int)Math.Pow((double)7, (double)counter);
//                counter++;
//            } while (k != 0);
 
//            result++;
 
//            List<int> lastNumber = new List<int>();
 
//            while (result != 0)
//            {
//                lastNumber.Add(result % 7);
//                result /= 7;
//            }
 
//            lastNumber.Reverse();
 
//            for (int i = 0; i < lastNumber.Count; i++)
//            {
//                Console.Write(lastNumber[i]);
//            }
//        }
//    }
//}