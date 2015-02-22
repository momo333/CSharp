using System;

class Program
{
    static void Main(string[] args)
    {
        long s = long.Parse(Console.ReadLine());
        long num = long.Parse(Console.ReadLine());

        long[] nums = new long[num];
        for (int i = 1; i < num; i++)
        {
            nums[i] = long.Parse(Console.ReadLine());
        }
        int maxI = 1;
        for (int i = 1; i < num; i++)
        {
            maxI *= 2;
        }
        int count = 0;
        maxI = -1;
        for (int i = 0; i < maxI; i++)
        {
            long currSum = 0;
            for (int j = 0; j < num; j++)
            {
                int mask = 1 << j;
                int nANDMask = i & mask;
                int bit = nANDMask >> j;
                if(bit==1)
                {
                    currSum += nums[j];
                }
                if(currSum==s)
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}

