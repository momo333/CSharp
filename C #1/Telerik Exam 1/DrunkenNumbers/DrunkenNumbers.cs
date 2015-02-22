//using System;

//class DrunkenNumbers
//{
//    static void Main()
//    {
//        int round = int.Parse(Console.ReadLine());
//        int count = 0;
//        while (countV < round)
//        {
//            string number = Console.ReadLine();
//            char[] arr = number.ToCharArray();
//            int length = arr.Length;
//            int countM = 0;
//            int countV = 0;
//            int count = 0;
//            if (length % 2 == 0)
//            {
//                for (int i = 0; i < length / 2 + 1; i++)
//                {
//                    while (i < length / 2)
//                    {
//                        int digit = (int)(arr[i] - '0');
//                        countM += digit;
//                    }
//                }
//                for (int i = length / 2; i < length; i++)
//                {

//                    int digit = (int)(arr[i] - '0');
//                    countV += digit;
//                }
//            }
//            else
//            {
//                for (int i = 0; i < length / 2 + 1; i++)
//                {
//                    while (i < (length / 2) + 1)
//                    {
//                        int digit = (int)(arr[i] - '0');
//                        countM += digit;
//                    }
//                }
//                for (int i = length / 2; i < length; i++)
//                {

//                    int digit = (int)(arr[i] - '0');
//                    countV += digit;
//                }
//            }
//            count++;
//        }
//        if (countM > countV)
//        {
//            Console.WriteLine("M {0}", countM);
//        }
//        else if (countM < countV)
//        {
//            Console.WriteLine("V {0}", countV);
//        }
//    }
//}

