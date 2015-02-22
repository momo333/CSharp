using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpression
{
    class MathExpression
    {
        static void Main()
        {
            double numN = double.Parse(Console.ReadLine());
            double numM = double.Parse(Console.ReadLine());
            double numP = double.Parse(Console.ReadLine());
            double remainder = ((int)numM)%180;
            const double one = 128.523123123;
            double nominator = (Math.Pow(numN, 2)) + (1 / (numM * numP)) + 1337;
            double denominator =  numN - (one * numP);
            double result = nominator / denominator + Math.Sin(remainder);
            Console.WriteLine("{0:F6}", result);
        }
       
    }
}
