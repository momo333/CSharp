
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.TheSecrets_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // int i=3%4;
            //Console.WriteLine(i);
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger num = 0;
            if (n < 0)
            {
                n = n * (-1);
            }
            BigInteger specSumOdd = 0;
            BigInteger specSumEven = 0;
            BigInteger lenght = Convert.ToString(n).Length;
            BigInteger copy = n;
            for (int i = 1; i <= lenght; i++)
            {
                num = copy % 10;
                copy /= 10;
                if ((i % 2) != 0)
                {
                    specSumOdd = specSumOdd + num * (int)(i * i);   //4*1     //4*9
                }
                else
                {
                    specSumEven = specSumEven + (BigInteger)(num * num) * i;   // 2*2*2
                }
            }
            BigInteger sumSpecial = specSumOdd + specSumEven;
            BigInteger checkLastdigit = sumSpecial % 10;
            Console.WriteLine(sumSpecial);
            if (checkLastdigit == 0)
            {
                Console.WriteLine(n + " has no secret alpha-sequence");
            }
            BigInteger sumR = 0;
            if (checkLastdigit != 0)
            {
                sumR = sumR + sumSpecial % 26;
                BigInteger letter = sumR + 65;
                for (int i = 0; i < checkLastdigit; i++)
                {
                    if (letter == 90)
                    {
                        Console.Write((char)letter);
                        letter = 65;

                    }
                    else if (letter < 90)
                    {
                        Console.Write((char)(letter));
                        letter++;
                    }

                }
                Console.WriteLine();
            }
        }
    }
}










//         while (copy > 0)
//        {
//            if (i % 2 == 0)
//            {
//                int digit = (int)(copy % 10);
//                sum += (digit * digit * i);
//            }
//            else
//            {
//                int digit = (int)(copy % 10);
//                sum += (i * i * digit);
//            }
//            copy /= 10;
//            i++;
//        }

//        Console.WriteLine(sum);
//        if (sum == 0 || (sum % 10 == 0))
//        {
//            Console.WriteLine("{0} has no secret alpha-sequence", number);
//        }
//        else if (sum > 0)
//        {
//            BigInteger lentSpec = sum % 10; ;
//            int sumRemainderPlusOne = (int)sum % 26;
//            for (BigInteger startLetter = lentSpec; startLetter < lentSpec * 2; startLetter++)
//            {

//                if (arr[sumRemainderPlusOne] != 'Z')
//                {
                    
//                    Console.Write(arr[sumRemainderPlusOne]);
//                    sumRemainderPlusOne++;
//                }
//                else
//                {
//                  sumRemainderPlusOne = 0;
//                }
//            }
//            Console.WriteLine();
//string number = Console.ReadLine();
//        int sum = 0;
//        char[] num = number.ToCharArray();
//        int length = num.Length;
//        for (int i = length; i >=1; i--)
//        {
//            if ((i % 2)!= 0)
//            {
//                int digit = (int)(num[i] - '0');
//                sum +=((digit * digit) * i);
//            }
//            else if((i%2)==0)
//            {
//                int digit = (int)(num[i] - '0');
//                sum += ((i*i) * digit);
//            }
//            //char[] arr = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 
//            //  'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
//        }