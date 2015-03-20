using System;


namespace PieceOfCake
{
    class PieceofCake
    {
        
        static void Main(string[] args)
        {
            decimal numA = int.Parse(Console.ReadLine());    
            decimal numB = int.Parse(Console.ReadLine());    
            decimal numC = int.Parse(Console.ReadLine());    
            decimal numD = int.Parse(Console.ReadLine());

            decimal result = numA /numB + numC/numD;


            if (result > 1)
            {
                Console.WriteLine("{0}", Math.Floor(result));
            }
            else
            {
                Console.WriteLine("{0:F22}", result);
            }
                decimal  denumerator = numB * numD;
                decimal numerator = ((numA * numD) + (numC * numB));
                decimal resultTwo = numerator / denumerator;
            
            Console.WriteLine("{0}/{1}",numerator,denumerator);
        }
    }
}


 //public static int determineLCM(int a, int b)
 //       {
 //           int num1, num2;
 //           if (a > b)
 //           {
 //               num1 = a; num2 = b;
 //           }
 //           else
 //           {
 //               num1 = b; num2 = a;
 //           }

 //           for (int i = 1; i <= num2; i++)
 //           {
 //               if ((num1 * i) % num2 == 0)
 //               {
 //                   return i * num1;
 //               }
 //           }
 //           return num2;
 //       }
 //       static void Main(string[] args)
 //       {
 //           int numA = int.Parse(Console.ReadLine());    //3
 //           int numB = int.Parse(Console.ReadLine());    //5
 //           int numC = int.Parse(Console.ReadLine());    //1
 //           int numD = int.Parse(Console.ReadLine());    //2
 //           int resultLCM = determineLCM(numB, numD);

 //           int remainderA = resultLCM / numB;     //2
 //           int remainderC = resultLCM / numD;     //5

 //           int numerator = remainderA * numA + remainderC * numC;
 //           int denumerator = resultLCM;
 //           if(numerator>=denumerator)
 //           {
 //               Console.WriteLine(numerator/denumerator);
               
 //           }
 //           else
 //           {
 //               denumerator = numB * numD;
 //               numerator = ((numA * numD) + (numC * numB));
 //               double result = (double)(numerator / denumerator);
 //               Console.WriteLine("{0:F22}", result);
                
 //           }
 //           Console.WriteLine("{0}/{1}", numerator, denumerator);
            