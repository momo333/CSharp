using System;
using System.Linq;
using System.Numerics;
using System.Text;
// C# Part 2 - 2012/2013 @ 11 Feb 2013
// 1. 9Gag Numbers
class NineGagNumbers
{
	static void Main()
	{
		string[] alpha = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };

		var input = Console.ReadLine();

		var currLetter = new StringBuilder();
		BigInteger result = 0;
		foreach (var c in input)
		{
			currLetter.Append(c);
			if (alpha.Contains(currLetter.ToString()))
			{
				int currDigit = Array.IndexOf(alpha, currLetter.ToString());
				result *= 9;
				result += currDigit;
				currLetter.Clear();
			}
		}
		Console.WriteLine(result);
	}
}
   



        //static void Main()
        //{
        //    string[] gagDigits = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
        //    string gagNumber = Console.ReadLine();

        //    List<byte> decDigits = new List<byte>();
        //    StringBuilder gagDigit = new StringBuilder();

        //    for (int i = 0; i < gagNumber.Length; i++)
        //    {
        //        gagDigit.Append(gagNumber[i]);
        //        for (byte j = 0; j < gagDigits.Length; j++)
        //        {
        //            if (gagDigit.ToString() == gagDigits[j])
        //            {
        //                decDigits.Add(j);
        //                gagDigit.Clear();
        //            }
        //        }
        //    }

        //    ulong decNumber = 0;
        //    for (int i = 0; i < decDigits.Count; i++)
        //    {
        //        decNumber = decNumber * 9 + (ulong)decDigits[i];
        //    }

        //    Console.Write(decNumber);
        //}