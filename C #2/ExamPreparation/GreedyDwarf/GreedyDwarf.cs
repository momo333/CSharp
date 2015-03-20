using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyDwarf
{
    class GreedyDwarf
    {
        static void Main(string[] args)
        {
            long maxSum = long.MinValue;
            string[] rawNums = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] valleyNums = new int[rawNums.Length];
            for (int i = 0; i < valleyNums.Length; i++)
            {
                valleyNums[i] = int.Parse(rawNums[i]);
            }
            int numberOfPatterns = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPatterns; i++)
            {
                long sum = CoinPattern(valleyNums);
                if(sum>maxSum)
                {
                    maxSum = sum;
                }
            }
            Console.WriteLine(maxSum);
        }
        private static long CoinPattern(int[] valley)
        {
            string[] rawNums = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[rawNums.Length];

            for (int i = 0; i < pattern.Length; i++)
            {
                pattern[i] = int.Parse(rawNums[i]);
            }
            long sum = 0;
            bool[] visited = new bool[valley.Length];

            sum += valley[0];
            visited[0] = true;
            int position = 0;

            while (true)
            {
                for (int i = 0; i < pattern.Length; i++)
                {
                    int nextMove = position + pattern[i];
                    if (nextMove >= 0 && nextMove < valley.Length && !visited[nextMove])
                    {
                        sum += valley[nextMove];
                        visited[nextMove] = true;
                        position = nextMove;
                    }
                    else
                        return sum;
                }
            }
        }
    }
}
