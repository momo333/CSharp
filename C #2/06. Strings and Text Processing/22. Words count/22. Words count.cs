﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//•	Write a program that reads a string from the console and lists all different words in the 
 //  string along with information how many times each word is found.
class WordsCount
{
  
    static void Main()
    {
        Console.WriteLine("Please enter a text: ");
        string text = Console.ReadLine();
        string regex = @"\b\w+\b";
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        MatchCollection words = Regex.Matches(text, regex);

        foreach (Match word in words)
        {
            if(dictionary.ContainsKey(word.ToString()))
            {
                dictionary[word.ToString()] += 1;
            }
            else
            {
                dictionary.Add(word.ToString(),1);
            }
        }
        foreach (var word in dictionary.OrderByDescending(m=>m.Value))
        {
            Console.WriteLine("{0} - {1}", word.Key, word.Value);
        }
    }
}