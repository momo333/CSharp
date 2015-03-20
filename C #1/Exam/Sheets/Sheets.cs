using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    class Sheets
    {
        static void Main(string[] args)
        {
            /*Asya loves confetti. One day she decided to create exactly N small pieces of sheets with paper size A10.
A10 is a standard for paper sizes. A9 is another standard that is twice as bigger as A10, so A9 can be cut into 2 pieces of size A10. A8 is twice as bigger as A9 and so on. A0 is twice as bigger as A1. See the picture on the left.
Asya has only one sheet of each type (totally 11 sheets). She wants to have exactly N pieces of size A10 by cutting as few sheets as possible.
Asya should not have any wasted sheets.
Write a program for her.
For example if we want to cut sheets into 9 pieces with the size of A10, we will use the only A7 sheet (cut into 8 pieces of size A10) and the only sheet with size A10. Then we will use 2 sheets. All other 9 sheets will not be used.
Input
On the only line of the input there will be the number N.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
Print the sizes of the sheets that will not be used after Asya’s cutting. Print one size on a single line.
The order of the paper sizes doesn’t matter. See the examples below.
Constraints
•     N will be between 0 and 2046, inclusive.
•     Allowed work time for your program: 0.1 seconds. Allowed memory: 16 MB.
 */
            int piecesOf10 = int.Parse(Console.ReadLine());
            List<int> paperValue = new List<int>() { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
            List<string> paperNames = new List<string>() { "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", };
            int index = 10;
            while (true)
            {
                if (piecesOf10 % 2 == 1)
                {
                    piecesOf10 -= 1;
                    paperNames.Remove(paperNames[index]);
                    paperValue.Remove(paperValue[index]);
                }
                piecesOf10 /= 2;
                if (index == 0)
                {
                    break;
                }
                index--;

            }
            foreach (var item in paperNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}







//﻿namespace Sheets
//{
//    using System;

//    class Sheets
//    {
//        static void Main()
//        {
//            int numberOfA10Sheets = int.Parse(Console.ReadLine());
//            int mask = 1;
//            for (int i = 0; i < 11; i++)
//            {
//                int maskToAply = mask << i;
//                if ((numberOfA10Sheets & maskToAply) == 0)
//                {
//                    Console.WriteLine("A{0}", 10 - i);
//                }
//            }
//        }
//    }
//}






//using System;


//namespace Sheets
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int number = int.Parse(Console.ReadLine());
//            string[] arr ={"A10", "A9", "A8", "A7", "A6", 
//                           "A5", "A4", "A3", "A2", "A1", "A0"};
//            int rest = 2046 - number;
//            if(number==0)
//            {
//                Console.WriteLine(0);
//            }
//            else if(number==1)
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    if (arr[i] != "A10")
//                    {
//                        Console.WriteLine(arr[i]);
//                    }
//                }
    
//            }
//             else if(number>1 && number<4)
//            {
//                if (number == 2)
//                {
//                    for (int i = 0; i < arr.Length; i++)
//                    {
//                        if (arr[i] != "A9")
//                        {
//                            Console.WriteLine(arr[i]);
//                        }
//                    }
//                }
//                else
//                {
//                    for (int i = 0; i < arr.Length; i++)
//                    {
//                        if (arr[i] != "A9" || arr[i] != "A10")
//                        {
//                            Console.WriteLine(arr[i]);
//                        }
//                    }
//                }
//            }
//             else if(number>3 && number<6)
//            {
//                if(number==4)
//                {
//                    for (int i = 0; i < arr.Length; i++)
//                    {
//                        if(arr[i]!="A8")
//                        {
//                            Console.WriteLine(arr[i]);
//                        }
//                    }
//                }
//                else 
//                {
//                    for (int i = 0; i < arr.Length; i++)
//                    {
//                        if(arr[i]!="A8" || arr[i]!="A10")
//                        {
//                            Console.WriteLine(arr[i]);
//                        }
//                    }
//                }
//            }
//            else if(number>5 && number<10)
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    if(arr[i]!="A7")
//                    {
//                        Console.WriteLine(arr[i]);
//                    }
//                }
//            }
//            else if(number>9 && number<18)
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    if(arr[i]!="A6")
//                    {
//                        Console.WriteLine(arr[i]);
//                    }
//                }
//            }
//            else if(number>17 && number<34)
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    if(arr[i]!="A5")
//                    {
//                        Console.WriteLine(arr[i]);
//                    }
//                }
//            }
//            else if(number>33 && number<66)
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    if(arr[i]!="A4")
//                    {
//                        Console.WriteLine(arr[i]);
//                    }
//                }
//            }
//             else if(number>65 && number<130)
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    if(arr[i]!="A3")
//                    {
//                        Console.WriteLine(arr[i]);
//                    }
//                }
//            }
//             else if(number>129 && number<258)
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    if(arr[i]!="A2")
//                    {
//                        Console.WriteLine(arr[i]);
//                    }
//                }
//            }
//             else if(number>257 && number<514)
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    if(arr[i]!="A1")
//                    {
//                        Console.WriteLine(arr[i]);
//                    }
//                }
//            }
//             else if(number>513 && number<1026)
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    if(arr[i]!="A0")
//                    {
//                        Console.WriteLine(arr[i]);
//                    }
//                }
//            }
                
//            else if(number>1025)
//            {
                
//            }

//        }
//    }
//}
