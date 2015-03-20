using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var magicWords = new List<string>();
        for (int i = 0; i < n; i++)
        {
            magicWords.Add(Console.ReadLine());
        }

        // Reorder

        for (int i = 0; i < n; i++)
        {
            var magicWord = magicWords[i];
            int position = magicWord.Length % (n + 1);
            magicWords.Insert(position, magicWord);

            if (position < i)
            {
                magicWords.RemoveAt(i + 1);
            }
            else
            {
                magicWords.RemoveAt(i);
            }
        }

        // Printing

        var maxLength = magicWords.Max(x => x.Length);

        var output = new StringBuilder();
        for (int i = 0; i < maxLength; i++)
        {
            foreach (string magicWord in magicWords)
            {
                if (magicWord.Length > i)
                {
                    output.Append(magicWord[i]);
                }
            }
        }

        Console.WriteLine(output);
    }
}