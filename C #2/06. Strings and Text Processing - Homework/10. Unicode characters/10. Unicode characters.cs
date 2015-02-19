using System;
using System.Text;
using System.Linq;
//•	Write a program that converts a string to a sequence of C# Unicode character literals.
//•	Use format strings.
class UnicodeCharacters
{
   static string ConvertToUnicode(string input)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            builder.AppendFormat("\\u{0:X4}", (int)input[i]);
        }
       return builder.ToString();
    }
    static void Main()
    {
        Console.WriteLine("Please enter a text");
        string input = Console.ReadLine();
        Console.WriteLine(ConvertToUnicode(input));

    }
}

