using System;
using System.Linq;
using System.Text;

// C# Part 2 - 2013/2014 @ 14 Sept 2013 - Evening
// 2. Moving Letters
class MovingLetters
{
    static void Main()
    {
        // Read input data
        string input = Console.ReadLine();
        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Aplying Nakov's algorithm
        var sequence = ExtractingLettersAlgorithm(words);
        var result = MovingLettersAlgorithm(sequence);

        // Printing the result
        Console.WriteLine(result);
    }

    private static StringBuilder MovingLettersAlgorithm(StringBuilder sequence)
    {
        for (int i = 0; i < sequence.Length; i++)
        {
            char currLetter = sequence[i];
            int alphaCode = char.IsLower(currLetter) ? currLetter - 'a' + 1 : currLetter - 'A' + 1;
            sequence.Remove(i, 1);
            int position = (i + alphaCode) % (sequence.Length + 1);
            sequence.Insert(position, currLetter);
        }

        return sequence;
    }

    private static StringBuilder ExtractingLettersAlgorithm(string[] words)
    {
        var result = new StringBuilder();
        int length = words.Max(x => x.Length);
        for (int index = 0; index < length; index++)
        {
            foreach (var word in words)
            {
                int currentLetterIndex = word.Length - 1 - index;
                if (currentLetterIndex >= 0)
                {
                    result.Append(word[currentLetterIndex]);
                }
            }
        }

        return result;
    }
}












//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MovingLetters
//{
//    class MovingLetters
//    {
//        static void Main(string[] args)
//        {
//            string[] words = Console.ReadLine().Split(' ');
//            string result = ExtractLetters(words);

//            result = MoveLetters(words);

//            Console.WriteLine(result);
//        }

//        private static string MoveLetters(string result)
//        {
//            StringBuilder builder = new StringBuilder(result);
//            for (int i = 0; i < result.Length; i++)
//            {
//                char letter = result[i];
//                int indexAlphabet = char.ToLower(letter) - 'a' + 1;
//                result = moveRight(builder, i, indexAlphabet);
//            }
//            return builder.ToString();
//        }

//        static void moveRight(StringBuilder builder, int index,int count)
//        {
//            char letter = builder[index];
//           builder.Remove(index,1);
//            int position = index  + count ;
//            while(position>builder.Length)
//            {
//                position-=builder.Length;
//            }
//            builder.Insert(position, letter);
//        }

//        private static string ExtractLetters(string[] words)
//        {
//            string result = string.Empty;
//            int maxWordLength = words.Max(word => word.Length);
//            for (int i = 0; i < maxWordLength; i++)
//            {
//                foreach (string word in words)
//                {
//                    int index = word.Length - 1 - i;
//                    bool condition = index >= 0;
//                    if (condition)
//                    {
//                        result += word[index];
//                    }

//                }

//            }
//            return result;
//        }
//    }
//}
