using System;


class Neurons
{
    static void Main()
    {
        while (true)
        {
            long line = int.Parse(Console.ReadLine());
            if (line == -1)
            {
                break;
            }
            int mostLeftIndex = 0;
            int mostRightIndex = 0;
            for (int i = 0; i < 32; i++)
            {
                long mask = 1 << i;
                long nAndMAsk = line & mask;
                long bit = nAndMAsk >> i;
                if (bit == 1)
                {
                    if(mostRightIndex==-1)
                    {
                        mostRightIndex = i;
                    }
                    mostLeftIndex = i;
                }
            }

            if(mostLeftIndex==-1)
            {
                Console.WriteLine(0);
                continue;
            }
            long result = 0;
            for (int p = mostRightIndex; p < mostLeftIndex; p++)
            {
                long mask = 1 << p;
                long nAndMask = line & mask;
                long bit = nAndMask >> p;
                if(bit ==0)
                {
                    result |= result;
                }
            }
            Console.WriteLine("{0} {1}", mostLeftIndex, mostRightIndex);
            //find most left 
            //find most right
            //between them set 1 to 0
            
        }
    }
}

