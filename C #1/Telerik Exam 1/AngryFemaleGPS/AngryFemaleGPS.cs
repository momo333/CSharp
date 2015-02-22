using System;


namespace AngryFemaleGPS
{
    class AngryFemaleGPS
    {
        static void Main(string[] args)
        {

            string number = Console.ReadLine();
            char[] num = number.ToCharArray();
            int length = num.Length;
            int sumEven =0;
            int sumOdd = 0;
            if(number == "0")
            {
                Console.WriteLine("straight 0");
                return;
            }
            for (int i = 0; i < length; i++)
			{
			     if((Math.Abs(num[i])%2)==0)
                 {
                     int digit = (int)(num[i]-'0');
                     sumEven+=digit;
                 }
                 else
                 {
                     int digit = (int)(num[i]-'0');
                     sumOdd+=digit;
                 }
			}
            if(sumEven>sumOdd)
            {
                Console.WriteLine("right" + " " + sumEven);
            }
            else if(sumEven<sumOdd)
            {
                Console.WriteLine("left" + " " + sumOdd);
            }
            else
            {
                Console.WriteLine("straight" + " " + sumEven);
            }
        }
    }
}




//Ad by BuyNsave | Close

//1
//using System;
//2
 
//3
//class AngryFemaleGPS
//4
//{
//5
//    static void Main(string[] args)
//6
//    {
//7
//        long number = long.Parse(Console.ReadLine());
//8
//        int even = 0;
//9
//        int odd = 0;
//10
 
//11
//        if (number < 0)
//12
//        {
//13
//            number *= -1;
//14
//        }
//15
//        if (number == 0)
//16
//        {
//17
//            Console.WriteLine("straight 0");
//18
//        }
//19
//        else
//20
//        {
//21
 
//22
//            while (number != 0)
//23
//            {
//24
//                long digit = number % 10;
//25
//                number /= 10;
//26
//                if (digit % 2 == 0)
//27
//                {
//28
//                    even += (int)digit;
//29
//                }
//30
//                else
//31
//                {
//32
//                    odd += (int)digit;
//33
//                }
//34
//            }
//35
//            if (even > odd)
//36
//            {
//37
//                Console.WriteLine("right {0}", even);
//38
//            }
//39
//            else if (odd > even)
//40
//            {
//41
//                Console.WriteLine("left {0}", odd);
//42
//            }
//43
//            else
//44
//            {
//45
//                Console.WriteLine("straight {0}", even);
//46
//            }
//47
//        }
//48
//    }
//49
