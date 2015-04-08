using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ClassMainGSM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter tests: ");
            int test = int.Parse(Console.ReadLine());
            CalHstoryTest.GSMCallHistory(test);
        }
    }
}
