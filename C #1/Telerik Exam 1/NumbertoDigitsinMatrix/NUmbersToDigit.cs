using System;


namespace NumbertoDigitsinMatrix
{
    class NUmbersToDigit
    {
        static void Main(string[] args)
        {
            int number = 1234567890;
            int len = number.ToString().Length;
            int[] iarray = new int[len];
            int index;
            for (index = 0; index < len; index++)
            {
                iarray[index] = number % 10;
                number /= 10;
            }
        }
    }
}
