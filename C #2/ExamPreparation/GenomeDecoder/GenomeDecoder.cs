using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomeDecoder
{
    class GenomeDecoder
    {
        static StringBuilder  DecodedGenome(string encoded)
        {
            StringBuilder decodedGenome = new StringBuilder();
            StringBuilder repeatTimes = new StringBuilder();
            foreach (var symbol in encoded)
            {
                if(symbol=='A' || symbol=='G' ||symbol=='T' ||symbol=='C')
                {
                    int repeat = 1;
                    if(repeatTimes.Length!=0)
                    {
                        repeat = int.Parse(repeatTimes.ToString());
                        repeatTimes.Clear();
                    }
                    string genomeSubSec = new string(symbol, repeat);
                    decodedGenome.Append(genomeSubSec);
                }
                else
                {
                    repeatTimes.Append(symbol);
                }
            }
            return decodedGenome;
        }
        static void Main(string[] args)
        {
            string[] inputFormat = Console.ReadLine().Split(new char[]{' '});
            int letersPerLineCount = int.Parse(inputFormat[0]);
            int lettersPerLineSec = int.Parse(inputFormat[1]);
            string encodedGenome = Console.ReadLine();
            StringBuilder decodedGenome = DecodedGenome(encodedGenome);
            PrintOutPut(decodedGenome,letersPerLineCount, lettersPerLineSec);
        }
        static void PrintOutPut(StringBuilder decodecGenome, int lettersPerLine, int lettersPerLineec)
        {
            int outputLines = (int)Math.Ceiling((double)(decodecGenome.Length / lettersPerLine));
            int maxLineNums = outputLines.ToString().Length;
            StringBuilder currFormatLines = new StringBuilder();
            int currentIndexIndecoded = 0;
            for (int line = 1; line <= outputLines; line++)
            {
                string frontInterval = new string(' ',maxLineNums-line.ToString().Length);
                currFormatLines.Append(frontInterval);
                currFormatLines.Append(line);
                currentIndexIndecoded = (line - 1) * lettersPerLine; ;
                for (int i = currentIndexIndecoded; i < line*lettersPerLine; i++)
                {
                    if(Math.Abs((currentIndexIndecoded-i)%lettersPerLineec)==0)
                    {
                        currFormatLines.Append(' ');
                    }
                    if(i>=decodecGenome.Length)
                    {
                        break;
                    }
                    currFormatLines.Append(decodecGenome[i]);
               }
            Console.WriteLine(currFormatLines);
            currFormatLines.Clear();
            }
            
        }
    }
}
