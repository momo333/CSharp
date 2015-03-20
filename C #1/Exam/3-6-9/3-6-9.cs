using System;
using System.Numerics;

namespace _3_6_9
{
    class Program
    {
        static void Main()
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int numC = int.Parse(Console.ReadLine());
            BigInteger numR = 0;

            switch(numB)
            {
                case 3: numR = numA + numC; 
                    break;
                case 6: numR = (BigInteger)numA * numC;
                    break;
                case 9: numR = numA % numC;
                    break;
            }
            BigInteger remainder=numR%3;
            if(remainder==0)
            {
                Console.WriteLine(numR/3);
          
            }
            else
            {
                Console.WriteLine(numR%3);
               
            }
            Console.WriteLine(numR);
        }
    }
}
