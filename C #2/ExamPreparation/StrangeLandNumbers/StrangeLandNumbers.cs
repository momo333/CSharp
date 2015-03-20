using System;

﻿using System;
using System.Linq;
using System.Numerics;
using System.Text;

// C# Part 2 - 2013/2014 @ 24 Jan 2014 - Evening
// 1. StrangeLand Numbers
class StrangeLandNumbers
{
	static void Main()
	{
		string[] alpha = { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };
		var input = Console.ReadLine();

		var currLetter = new StringBuilder();
		BigInteger result = 0;
		foreach (var c in input)
		{
			currLetter.Append(c);
			if (alpha.Contains(currLetter.ToString()))
			{
				int currDigit = Array.IndexOf(alpha, currLetter.ToString());
				result *= 7;
				result += currDigit;
				currLetter.Clear();
			}
		}

		Console.WriteLine(result);
	}
}
   








        //static void Main(string[] args)
        //{
        //    string strangeNumber = Console.ReadLine().Replace("f", "0").Replace("bIN", "1")
        //        .Replace("bIN", "2").Replace("oBJEC", "3").Replace("mNTRAVL", "4").Replace("lPVKNQ", "5")
        //        .Replace("pNWE", "6").Replace("hT", "7");
        //    int power = 0;
        //    BigInteger result = 0;
        //    for (int i = 0; i < strangeNumber.Length; i++)
        //    {
        //        int currentNum = strangeNumber[i] - '0';
        //        result += currentNum;
        //    }
        //    ulong decNumber = 0;
        //    for (int i = 0; i < strangeNumber.Length; i++)
        //    {
        //        decNumber = decNumber * 9 + (ulong)decDigits[i];
        //    }
        //}