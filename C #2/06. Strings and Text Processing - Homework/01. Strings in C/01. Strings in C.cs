using System;
/*•	Describe the strings in C#.
          •	What is typical for the string data type?
          •	Describe the most important methods of the String class.*/
class StringsInC
{
    static void Main()
    {
        string str = Console.ReadLine();
        for (int i = str.Length-1; i >=0; i--)
        {
            Console.Write(str[i]);
        }

    }
}
