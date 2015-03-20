using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialValue
{
    class SpecialValue
    {
        static int[][] ReadData(int[][] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                string[] currLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                field[i] = new int[currLine.Length];
                for (int j = 0; j < currLine.Length; j++)
                {
                    field[i][j] = int.Parse(currLine[j]);
                }
            }
            return field;
        }
        static long FindCurrSpecialValue(int[][] field, int column,
            bool[][] used)
        {
            long result = 0;
            int currentRow = 0;

            while (true)
            {
                result++;
                if(used[currentRow][column])
                {
                    return long.MinValue;
                }
                
                if(field[currentRow][column]<0)
                {
                    result -= field[currentRow][column];
                    return result;
                }
                currentRow++;
                int nextColumn = field[currentRow][column];
                used[currentRow][column] = true;
                column = nextColumn;
                if(currentRow==field.GetLength(0))
                {

                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int[][] field = new int[row][];
            long max= long.MinValue;
            ReadData(field);
            bool[][] used = new bool[row][];
            for (int i = 0; i < row; i++)
            {
                used[i] = new bool[field[i].Length];
            }
            for (int i = 0; i < field[0].Length; i++)
            {
                long specialValue = FindCurrSpecialValue(field, i, used);
                if(max<specialValue)
                {
                    max = specialValue;
                }
            }
            Console.WriteLine(max);
        }
    }
}
