using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Tubes
{
    class Tubes
    {
        static void Main(string[] args)
        {
            long tubes = int.Parse(Console.ReadLine());
            long friends = int.Parse(Console.ReadLine());
            long[] tubesSize = new long[tubes];
            long min = long.MaxValue;
            long max = long.MinValue;

            for (int i = 0; i < tubes; i++)
            {
                tubesSize[i] = long.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tubes; i++)
            {
                if (tubesSize[i] < min)
                {
                    min = tubesSize[i];
                }
                if (tubesSize[i] > max)
                {
                    max = tubesSize[i];
                }
            }
            long left = 1;
            long right = max;
            long middle = (left + right) / 2;
            long finalRes = -1;
            while(left<=right)
            {
                long eventual = 0;
                for (int j = 0; j < tubesSize.Length; j++)
                {
                    eventual += tubesSize[j] / middle;
                    if(eventual<friends)
                    {
                        right = middle - 1;
                    }
                    else if(eventual>=friends)
                    {
                        left = middle + 1;
                        finalRes = middle;
                    }
                    middle=(left +right)/2;
                }
                
            }
            Console.WriteLine(finalRes);
        }
    }
}
//for (long i = max; i > 1; i--)
            //{
            //    long evetual = 0;
            //    for (long j = 0; j < tubesSize.Length; j++)
            //    {
            //        evetual += tubesSize[j] / i;
            //    }
            //    if (evetual >= friends)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}