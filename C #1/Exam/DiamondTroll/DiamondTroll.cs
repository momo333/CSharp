using System;



class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int width = 2 * number + 1;
        int numdots = (width - number) / 2;
        char dot = '.';
        char star = '*';
            Console.Write(new string(dot, numdots));
            Console.Write(new string(star, number));
            Console.Write(new string(dot, numdots));
            int middledots = (number - 1) / 2;
            Console.WriteLine();
            numdots -= 1;
        for (int i = 0; i < number/2; i++)
        {
            
            Console.Write(new string(dot, numdots));
            Console.Write(star);
            Console.Write(new string(dot, middledots));
            Console.Write(star);
            Console.Write(new string(dot, middledots));
            Console.Write(star);
            Console.Write(new string(dot, numdots));
            Console.WriteLine();
            numdots--;
            middledots++;
        }
        Console.WriteLine(new string(star,width));
        int midDots = number - 2;
        int startDots = 1;
        for (int i = 0; i < number-1; i++)
        {
            Console.Write(new string(dot,startDots));
            Console.Write(star);
            Console.Write(new string(dot, midDots));
            Console.Write(star);
            Console.Write(new string(dot, midDots));
            Console.Write(star);
            Console.Write(new string(dot, startDots));
            Console.WriteLine();
            midDots--;
            startDots++;
        }
        Console.Write(new string(dot,(width-1)/2));
        Console.Write(star);
        Console.Write(new string(dot, (width - 1) / 2));
    }
}

