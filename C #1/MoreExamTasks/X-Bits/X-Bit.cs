using System;

class Program
{
    static void Main(string[] args)
    {
        long[,] arr = new long[8, 32];
        for (int row = 0; row < 8; row++)
        {
            long number = long.Parse(Console.ReadLine());
            for (int col = 0; col < 32; col++)
            {
                int mask = 1;
                arr[row, col] = (number >> col) & 1;
            }
        }
        int counter =0;
        for (int i = 1; i < 8-1; i++)
        {
            for (int j = 1; j < 31; j++)
            {
                if ((arr[i - 1, j - 1] == 1) &&
                    (arr[i - 1, j + 1] == 1) && (arr[i, j] == 1) &&
                    (arr[i + 1, j - 1] == 1) && (arr[i + 1, j + 1] == 1) 
                    && ( arr[i-1,j]==0) && (arr[i,j-1]==0) && 
                    (arr[i,j+1]==0) &&(arr[i+1,j]==0))
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}


//using System;

//class XBits
//{
//    static void Main()
//    {
//        int[] numbers = new int[8];

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = int.Parse(Console.ReadLine());            
//        }

//        int xCounter = 0;
//        for (int i = 0; i < numbers.Length-2; i++)
//        {
//            for (int j = 0; j < 32; j++)
//            {
//                bool upX = ((numbers[i] >> j) & 7) == 5 ;
//                bool middleX = ((numbers[i+1] >> j) & 7) == 2 ;
//                bool downX = ((numbers[i+2] >> j) & 7) == 5 ;

//                if (upX && middleX && downX)
//                {
//                    xCounter++;
//                }
//            }
//        }

//        Console.WriteLine(xCounter);        
//    }
//}


////﻿using System;

////class XBits
////{
////    static void Main()
////    {
////        int[] numbers = new int[8];
////        int counter = 0;

////        for (int i = 0; i < numbers.Length; i++)
////        {
////            numbers[i] = int.Parse(Console.ReadLine());
////        }

////        string[] numbersStr = new string[8];

////        for (int i = 0; i < numbers.Length; i++)
////        {
////            numbersStr[i] = Convert.ToString(numbers[i], 2).PadLeft(32, '0');
////        }

////        for (int i = 0; i <= 5; i++)
////        {
////            for (int s = 0; s <= 29; s++)
////            {
////                if (numbersStr[i].Substring(s, 3) == "101" && numbersStr[i + 1].Substring(s, 3) == "010" 
////                 && numbersStr[i + 2].Substring(s, 3) == "101")
////                {
////                    counter++;
////                }
////            }
////        }
////        Console.WriteLine(counter);      
////    }
////}


////﻿using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace _5_X_Bits
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            char[,] matrix = new char[8, 32];

////            for (int i = 0; i < matrix.GetLength(0); i++)
////            {
////                int number = int.Parse(Console.ReadLine());
////                string numberAsBinary = Convert.ToString(number, 2).PadLeft(32, '0');
////                for (int j = 0; j < matrix.GetLength(1); j++)
////                {
////                    matrix[i, j] = numberAsBinary[numberAsBinary.Length - j - 1];
////                }
////            }

////            int foundXbits = 0;
////            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
////            {
////                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
////                {
////                    if (matrix[i, j] == '1' && matrix[i, j + 1] == '0' && matrix[i, j + 2] == '1')
////                    {
////                        if (matrix[i+1, j] == '0' && matrix[i + 1, j + 1] == '1' && matrix[i + 1, j + 2] == '0')
////                        {
////                            if (matrix[i+2, j] == '1' && matrix[i+2, j+1] == '0' && matrix[i+2, j+ 2] == '1')
////                            {
////                                foundXbits++;
////                            }
////                        }
////                    }
////                }
////            }

////            Console.WriteLine(foundXbits);
////        }
////    }
////}