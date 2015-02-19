using System;
using System.Linq;
using System.Collections.Generic;
//Problem 5. Sort by string length
//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
class Program
{
  static void Main()
    {
	// Initialize a List of strings.
	List<string> sampleList = new List<string>
	{
	    "one",
	    "two",
	    "three",
	    "four",
	    "five",
	    "six"
	};
	// Send the List to the method.
	foreach (string s in SortByLength(sampleList))
	{
	    Console.WriteLine(s);
	}
    }

    static IEnumerable<string> SortByLength(IEnumerable<string> e)
    {
	// Use LINQ to sort the array received and return a copy.
	var sorted = from s in e
		     orderby s.Length ascending
		     select s;
	return sorted;
    }
    
}

