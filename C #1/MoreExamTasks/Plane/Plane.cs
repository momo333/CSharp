

using System;

class Plane
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', n + (n / 2)));
        int preDot = n + (n / 2) - 1;
        int dotsMiddle = 1;

        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', preDot), new string('.', dotsMiddle));
            dotsMiddle += 2;
            preDot--;
        }

        preDot = n;
        dotsMiddle = n + 2;
        for (int i = 0; i < n / 2; i++)
        {
            preDot -= 2;
            Console.WriteLine("{0}*{1}*{0}", new string('.', preDot), new string('.', dotsMiddle));
            dotsMiddle += 4;
        }

        preDot = n - 2;
        dotsMiddle = n;
        int dotsBetween = 1;
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', preDot), new string('.', dotsMiddle));
        for (int i = 0; i < (n / 2) - 1; i++)
        {
            preDot -= 2;
            Console.WriteLine(
                "*{0}*{2}*{1}*{2}*{0}*", new string('.', preDot), new string('.', dotsMiddle), new string('.', dotsBetween));  dotsBetween += 2;
        }

        preDot = n - 2;
        preDot++;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', preDot), new string('.', dotsMiddle));
            preDot--;
            dotsMiddle += 2;
        }

        Console.WriteLine(new string('*', n * 3));
    }
}
