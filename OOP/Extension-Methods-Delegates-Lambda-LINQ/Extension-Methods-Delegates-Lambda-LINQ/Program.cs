using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("the white rabbit play whole day in the near forest");
            Console.WriteLine(builder.SubString(5, 10));
            Console.WriteLine(builder.SubString(15));
        }
    }
}
