using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace multiverceCommunication
{
    class MultivereCommunication
    {
        static void Main(string[] args)
        {
            var alphabet = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
            var input = Console.ReadLine();
            long decimalNum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var digitIn13Base = input.Substring(i, 3);
                var decimalValue = alphabet.IndexOf(digitIn13Base);
                decimalNum *= 13;
                decimalNum += decimalValue;
            }
            Console.WriteLine(decimalNum);
        }
    }
}
