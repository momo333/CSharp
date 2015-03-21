using System;
using System.Numerics;


namespace CheatSheet
{
    class CheatSheet
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            long horNum = int.Parse(Console.ReadLine());
            long vertNum = int.Parse(Console.ReadLine());
            long  borderRow = vertNum + rows;
            long  borderCol = horNum + cols;
            BigInteger[,] arr = new BigInteger[rows, cols];
           
            for (long i = vertNum, row=0; i <borderRow && row<rows; i++, row++)      //4 + 3 = 7
            {
                for (long j = horNum, col=0; j < borderCol && col<cols; j++, col++)   //8 + 5 = 13 
                {
                     arr[row,col]= i * j;
                    Console.Write(arr[row,col] + " ");
                    
                }
                Console.WriteLine();
   
            }
        }
    }
}



//using System;

//public class CheatSheet
//{
//    public static void Main()
//    {
//        int rows = int.Parse(Console.ReadLine());
//        int cols = int.Parse(Console.ReadLine());
//        long vNumber = int.Parse(Console.ReadLine());
//        long hNumber = int.Parse(Console.ReadLine());

//        for (long row = vNumber; row < vNumber + rows; row++)
//        {
//            for (long col = hNumber; col < hNumber + cols; col++)
//            {
//                Console.Write(row * col);

//                if (col < hNumber + cols - 1)
//                {
//                    Console.Write(' ');
//                }
//            }

//            Console.WriteLine();
//        }
//    }
//}