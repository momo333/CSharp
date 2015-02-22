using System;


namespace BinaryDigitsCount
{
    class BinaryDigitsCount
    {

        static void zeroesCount(long number)
        {
            int ones = 0, zeroes=0;
            for (int i = 0; i < 8; i++)
            {
                int mask = 1 << i;
                if ((number & mask) == 0)
                {
                    zeroes++;
                }
                else
                    ones++;
            }
            Console.WriteLine(ones);
        }
         
        static void onesCount(long number)
        {
            int ones = 0, zeroes = 0;
            for (int i = 0; i < 8; i++)
            {
                int mask = 1 << i;
                if ((number & mask) == 0)
                {
                    zeroes++;
                }
                else
                    ones++;
            }
            Console.WriteLine(zeroes);
        }
        static void Main(string[] args)
        {
            int binary = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                long digitNum = long.Parse(Console.ReadLine());
                if(binary==1)
                {
                    onesCount(number);
                }
                else
                {
                    zeroesCount(number);
                }
            }
        }
    }
}
