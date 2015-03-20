using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BunnyFactory
{
    class BunnyFactory
    {

        static List<int> ReadInput()
        {
            List<int> bunnies = new List<int>();
            var input = Console.ReadLine();
            while (input != "END")
            {
                bunnies.Add(int.Parse(input));
                input = Console.ReadLine();
            }
            return bunnies;
        }
        static void Main(string[] args)
        {
            var cages = ReadInput();
            for (int stepNum = 1; ; stepNum++)
            {
                if (cages.Count < stepNum)
                {
                    break;
                }
                var cagesCount = (int)SumListValues(cages, 0, stepNum - 1);
                if (cages.Count < stepNum + cagesCount)
                {
                    break;
                }
                var sum = SumListValues(cages, stepNum, cagesCount + stepNum - 1);
                var product = ProductListValues(cages, stepNum, cagesCount + stepNum - 1);

                string result = sum.ToString() + product.ToString();
                for (int i = cagesCount + stepNum; i < cages.Count; i++)
                {
                    result += cages[i];
                }
                var newcages = new List<int>();
                foreach (var ch in result)
                {
                    if (ch != '0' && ch != '1')
                    {
                        cages.Add(ch - '0');
                    }
                }
            }
            Console.WriteLine(string.Join(" ", cages));
        }
        static BigInteger ProductListValues(List<int> list, int start, int end)
        {
            int product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= list[i];
            }
            return product;
        }

        static BigInteger SumListValues(List<int> list, int startIndex, int endnIndex)
        {
            BigInteger sum = 0;
            for (int i = startIndex; i < endnIndex; i++)
            {
                sum += list[i];
            }
            return sum;
        }
    }
}
