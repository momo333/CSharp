using System;


class Egg
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int height = 2 * N;
        int Eggwidth = 3 * N - 1;
        int drawingAreaWidth = 3 * N + 1;
        int counterHeight = 0;

        //Top
        Console.Write(new string('.', 1));
        Console.Write(new string('.', N));
        Console.Write(new string('*', Eggwidth - N * 2));
        Console.Write(new string('.', N));
        Console.Write(new string('.', 1));
        counterHeight++;
        Console.WriteLine();

        //print slope top side:
        int loopSize = N - 2;
        int mask = N;

        if (loopSize >= 1)
        {
            for (int i = 0; i < loopSize; i++)
            {
                if (mask < 1)
                {
                    break;
                }
                Console.Write(new string('.', 1));
                Console.Write(new string('.', mask - 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', Eggwidth - mask * 2 + 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', mask - 2));
                Console.Write(new string('.', 1));
                mask -= 2;
                counterHeight++;
                Console.WriteLine();
            }
        }

        //print top sides:
        int maskWidth = (N * 2 - (counterHeight * 2) - 2) / 2;
        if (maskWidth > 0)
        {
            for (int i = 0; i < maskWidth; i++)
            {
                Console.Write(new string('.', 1));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', Eggwidth - 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', 1));
                counterHeight++;
                Console.WriteLine();
            }
        }

        //Printing the middle:
        Console.Write(new string('.', 1));
        Console.Write(new string('*', 1));

        for (int i = 0; i < Eggwidth - 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write('@');
            }
            else
            {
                Console.Write('.');
            }
        }

        Console.Write(new string('*', 1));
        Console.Write(new string('.', 1));
        counterHeight++;
        Console.WriteLine();

        //Second line of the middle:
        Console.Write(new string('.', 1));
        Console.Write(new string('*', 1));
        for (int i = 0; i < Eggwidth - 2; i++)
        {
            if (i % 2 == 1)
            {
                Console.Write('@');
            }
            else
            {
                Console.Write('.');
            }
        }
        Console.Write(new string('*', 1));
        Console.Write(new string('.', 1));
        counterHeight++;
        Console.WriteLine();

        //print bottom:
        //print bottom sides:
        for (int i = 0; i < maskWidth; i++)
        {
            Console.Write(new string('.', 1));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', Eggwidth - 2));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', 1));
            counterHeight++;
            Console.WriteLine();
        }

        int loopsLeft = height - counterHeight - 1;
        int z = 0;

        for (int i = 0; i < loopsLeft; i++)
        {
            Console.Write(new string('.', 1));
            Console.Write(new string('.', z));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', Eggwidth - 2 * z - 2));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', z));
            Console.Write(new string('.', 1));
            z += 2;
            Console.WriteLine();
        }

        Console.Write(new string('.', 1));
        Console.Write(new string('.', N));
        Console.Write(new string('*', Eggwidth - N * 2));
        Console.Write(new string('.', N));
        Console.Write(new string('.', 1));
        counterHeight++;
        Console.WriteLine();
    }
}