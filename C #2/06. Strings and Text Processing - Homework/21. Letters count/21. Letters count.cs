using System;
using System.Text.RegularExpressions;
//•	Write a program that reads a string from the console and prints all different letters in the 
//  string along with information how many times each letter is found.
class LettersCount
{

    static void Main()
    {
        string text = Console.ReadLine();
        char[] alphabet = new char[]{'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        int lengthAlphabet = 26;
        int[] array = new int[lengthAlphabet];
        int[] count = new int[lengthAlphabet];
        int length = text.Length;
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < lengthAlphabet; j++)
            {
                if (text[i] == alphabet[j])
                {
                    if (array[j] < 1)
                    {
                        Console.Write("{0}", text[i]);
                    }
                    array[j]++;
                    count[j]++;
                }
            }
        }
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("The text has letter {0} :  {1} times ", alphabet[i], count[i]);
        }
    }
}

//        string text = Console.ReadLine();
//        string regex = @"(?:([a-z,A-Z])(?!.*\1)\s*)*";
//        MatchCollection matches = Regex.Matches(text, regex);
//        string str = String.Empty;
//        foreach (Match match in matches)
//        {
//            foreach (Capture capture in match.Captures)
//            {
//                str += capture.Value;
//            }
//        }
//        Console.WriteLine(str);