using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int width = 2 * number - 1;
        int height = 2 * number - 1;
        int numStrDots = number / 2;
        char dot ='.';
        char sharp ='#';
        Console.WriteLine("{0}{1}{2}", new string(dot, numStrDots), new string(sharp,number), new string(dot, numStrDots));
        int middleDot = number - 2;
        for (int i = 0; i < number-2; i++)
        {
          
            Console.WriteLine("{0}{1}{2}{3}{4}", new string(dot, numStrDots), sharp, new string(dot, middleDot), sharp, new string(dot, numStrDots));
        }

        Console.WriteLine("{0}{1}{2}", new string(sharp, numStrDots + 1), new string(dot, middleDot), new string(sharp, numStrDots + 1));
        int numDot = 1;
        for (int i = 0; i < number-2; i++)
        {
            int middle = width - 2 - 2*numDot;
            Console.WriteLine("{0}{1}{2}{3}{4}", new string(dot, numDot), sharp, new string(dot, middle), sharp, new string(dot, numDot));
            numDot++;
        }
        Console.WriteLine("{0}{1}{2}", new string(dot, number-1), sharp, new string(dot, number-1));
    }
}
