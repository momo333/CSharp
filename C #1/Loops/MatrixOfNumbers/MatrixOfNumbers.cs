using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("The program generates matrix of numbers");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 1; i < num; j++)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine(i);
            }
        }
    }
}
