using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int height = number;
        int numDots = 0;
        int width = 2 * (number - 1) + 2;
        char dot = '.';
        char dash = '-';
        char slash = '/';
        char bcslash = '\\';
        string strDot = new string(dot, number - 1);
        numDots = number - 1;
        Console.WriteLine("{0}{1}{2}{3}", strDot, slash, bcslash, strDot);
        for (int i = 0; i < number - 1; i++)
        {
            numDots--;
            int middleDot = width - 2 - (2 * numDots);
            int midDashes = width - 2 - (2 * numDots);
            string dashRow = new string(dash, midDashes);
            strDot = new string(dot, numDots);
            string middleDots = new string(dot, middleDot);

            if (i == 0 || i == 2 || i == 5 || i == 9 || i == 14 || i == 20 || i == 27 || i == 35)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", strDot, slash, dashRow, bcslash, strDot);
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", strDot, slash, middleDots, bcslash, strDot);
            }
        }
     }
}



//using System;

//public class Program
//{
//    public static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        int counter = -2;
//        for (int row = 0; row < n; row++)
//        {
//            for (int i = 0; i <= counter; i++)
//            {

//                Console.Write(new string('.', n - row - 1));
//                Console.Write("/");
//                Console.Write(new string('.', row));

//                Console.Write(new string('.', row));
//                Console.Write("\\");
//                Console.Write(new string('.', n - row - 1));
//                Console.WriteLine();

//                row++;
//                if (row == n)
//                {
//                    return;
//                }
//            }

//            Console.Write(new string('.', n - row - 1));
//            Console.Write("/");
//            Console.Write(new string('-', row));

//            Console.Write(new string('-', row));
//            Console.Write("\\");
//            Console.Write(new string('.', n - row - 1));
//            Console.WriteLine();

//            counter++;
//        }
//    }
//}
