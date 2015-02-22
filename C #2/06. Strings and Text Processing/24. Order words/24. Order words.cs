using System;
using System.Collections.Generic;
//•	Write a program that reads a list of words, separated by spaces 
 //  and prints the list in an alphabetical order.
class OrderWords
{
    static void Main()
    {
        char[] separator = { ',', ' ' };
        string text = Console.ReadLine();
        string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        List<string> listedWords = new List<string>();
        int length = words.Length;
        for (int i = 0; i <length; i++)
        {
            if(!listedWords.Contains(words[i]))
            {
                listedWords.Add(words[i]);
            }
        }
        listedWords.Sort();
        for (int i = 0; i < length; i++)
        {
            Console.Write(listedWords[i] + " ");
        }
    }
}
