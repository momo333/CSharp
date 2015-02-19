﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//•	Write a program that extracts from a given text all sentences containing given word.
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.
class ExtractSentences
{
    static void Main()
    {
        string text = Console.ReadLine();
        MatchCollection matchList = Regex.Matches(text, @"([^\.]*\bin\b[^\.]*)");
        foreach (Match sentence in matchList)
        {
            Console.WriteLine(sentence);
        }
    }
}

