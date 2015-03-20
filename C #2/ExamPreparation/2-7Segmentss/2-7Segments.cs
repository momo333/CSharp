using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7Segmentss
{
    class Program
    {
        static int[,] display ={{1,1,1,1,1,1,0},   //0
            {0,1,1,0,0,0,0},         //1
            {1,1,0,1,1,0,1},          //2
            {1,1,1,1,0,0,1},          //3
            {0,1,1,0,0,1,1},           //4
            {1,0,1,1,0,1,1},          //5
            {1,0,1,1,1,1,1},           //6
            {1,1,1,0,0,0,0},          //7
            {1,1,1,1,1,1,1},           //8
            {1,1,1,1,0,1,1},           //9
        };

        static StringBuilder builder = new StringBuilder();
        static int[] array = new int[10];
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string states = Console.ReadLine();
                CheckForMatch(states);
            }
        }
        private static void CheckForMatch(string states)
        {
            switch(states)
            {
                case "1111110": array[0]++; break;
                case "0110000": array[1]++; break;
                case "1101101": array[2]++; break;
                case "1111001": array[3]++; break;
                case "0110011": array[4]++; break;
                case "1011011": array[5]++; break;
                case "1011111": array[6]++; break;
                case "1110000": array[7]++; break;
                case "1111111": array[8]++; break;
                case "1111011": array[9]++; break;
            }
        }
    }
}
