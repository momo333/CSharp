using System;


namespace _2_4_8
{
    class Program
    {
        static void Main()
        {
            long numberA = long.Parse(Console.ReadLine());
            long numberB = long.Parse(Console.ReadLine());
            long numberC = long.Parse(Console.ReadLine());
            long numberR=0;
            switch(numberB)
            {
                case 2:
                    numberR = numberA % numberC;
                    break;
                case 4:
                    numberR = numberA + numberC;
                    break;
                case 8:
                    numberR = numberA * numberC;
                    break;
            }
            long remainder = numberR % 4;
            if(remainder==0)
            {
                Console.WriteLine(numberR/4);
            }
            else
            {
                Console.WriteLine(numberR%4);
            }
            Console.WriteLine(numberR);
        }
    }
}

            //if (numberB==2)
            //{
            //    int numR=numberA%numberC;
            //    int remainder = numR % 4;
            //    if(remainder==0)
            //    {
            //        Console.WriteLine(numR/4);
            //    }
            //    else
            //    {
            //        Console.WriteLine(numR%4);
                    
            //    }
            //    Console.WriteLine(numR);
            //}
            //  if(numberB==4)
            //{
            //     int numR=numberA+numberC;
            //     int remainder = numR % 4;
            //     if (remainder== 0)
            //     {
            //         Console.WriteLine(numR / 4);
            //     }
            //     else
            //     {
            //         Console.WriteLine(numR % 4);
            //     }
            //    Console.WriteLine(numR);
            //}
            //    if(numberB==8)
            //{
            //    int numR = numberA * numberC;
            //    int remainder = numR % 4;
            //    if (remainder == 0)
            //    {
            //        Console.WriteLine(numR / 4);
            //    }
            //    else
            //    {
            //        Console.WriteLine(numR % 4);
                    
            //    }
            //    Console.WriteLine(numR);
            //}