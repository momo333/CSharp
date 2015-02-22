using System;
using System.Text;

class TelerikLogo
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int Y = X;
        int Z = (X + 1) / 2;

        int colNums = 3 * X - 2;

        for (int i = 0; i < 2 * X - 2; i++)
        {
            StringBuilder line = new StringBuilder(new string('.', colNums));

            if (Z - 1 - i >= 0)
            {
                line[Z - 1 - i] = '*';
            }
            line[Z - 1 + i] = '*';

            line[colNums - Z - i] = '*';
            if (colNums - Z + i < colNums)
            {
                line[colNums - Z + i] = '*';
            }

            Console.WriteLine(line);
        }

        for (int i = 0; i < X; i++)
        {
            StringBuilder line = new StringBuilder(new string('.', colNums));
            line[Z - 1 + i] = '*';
            line[colNums - Z - i] = '*';
            Console.WriteLine(line);
        }
    }
}