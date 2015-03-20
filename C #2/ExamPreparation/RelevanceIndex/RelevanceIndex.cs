using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevanceIndex
{
    class RelevanceIndex
    {
        static string word;
        static void PrintText(List<string> text)
        {
            for (int i = text.Count-1; i >=0; i--)
            {
                Console.WriteLine(text[i]);
            }
        }
        static string RemovePunctuation(string line)
        {
            var sb = new StringBuilder();

            foreach (char ch in line)
            {
                if (!char.IsPunctuation(ch))
                    sb.Append(ch);
            }
            string str = sb.ToString();
            return str;
        }
        static string ConvertWordToCapital(string str)
        {
            string modifiedCapital = str.Replace(word, (word.ToUpper()));
            return modifiedCapital;
        }
      
        static void Main(string[] args)
        {
            word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string ch = "";
            List<string> listLines = new List<string>();
            for (int i = 0; i < n; i++)
            {
             ch = Console.ReadLine();
            string newString = RemovePunctuation(ch);
            string replacedWithCapital = ConvertWordToCapital(newString);
            listLines.Add(replacedWithCapital);
            }
            PrintText(listLines);
        }
    }
}
