using System;
using System.Numerics;

class Tibonacci
{
    static void Main(string[] args)
    {
        BigInteger numOne = int.Parse(Console.ReadLine());
        BigInteger numTwo = int.Parse(Console.ReadLine());
        BigInteger numThree = int.Parse(Console.ReadLine());
        BigInteger numN = int.Parse(Console.ReadLine());
        BigInteger numFibb = 0;   //Da ne zabraviame granichnite sluchai
        if(numN==1)
        {
            Console.WriteLine(numOne);
        }
        if(numN==2)
        {
            Console.WriteLine(numTwo);
        }
        if(numN==3)
        {
            Console.WriteLine(numThree);
        }
        else
            {
                for (int i = 4; i <= numN; i++)
                {
                    numFibb = numOne + numTwo + numThree;
                    numOne = numTwo;
                    numTwo = numThree;
                    numThree = numFibb;
                }
            }
        Console.WriteLine(numFibb);
    }
}



//using System;
//using System.Numerics;

//namespace Tribonacci
//{
//    class Tribonacci
//    {
//        static void Main(string[] args)
//        {

//            BigInteger first = BigInteger.Parse(Console.ReadLine());
//            BigInteger second = BigInteger.Parse(Console.ReadLine());
//            BigInteger third = BigInteger.Parse(Console.ReadLine());
//            int n = int.Parse(Console.ReadLine());
//            BigInteger tribN = 0;
//            if (n == 1)
//            {
//                Console.WriteLine(first);
//            }
//            else
//            {
//                if (n == 2)
//                {
//                    Console.WriteLine(second);
//                }
//                else
//                {
//                    if (n == 3)
//                    {
//                        Console.WriteLine(third);
//                    }
//                    else 
//                    {
//                        for (int i = 4; i <= n; i++)
//                        {
//                            tribN = first + second + third;
//                            first = second;
//                            second = third;
//                            third = tribN;
//                        }
//                        Console.WriteLine(tribN);
//                    }
//                }
//            }
//        }
//    }
//}

