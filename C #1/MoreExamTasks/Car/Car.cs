using System;

    class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int width = 3 * num;
        Console.Write(new string('.',num));
        Console.Write(new string('*', num));
        Console.Write(new string('.', num));
        Console.WriteLine();
        int numdots = num;
        char star= '*';
        char dot = '.';
        int numMiddleDots = num;
        for(int i = 0; i < num/2-1; i++)
        {
            
            numdots--;
            string dots = new string(dot, numdots);
            string middleDot=new string(dot,numMiddleDots);
            Console.WriteLine("{0}{1}{2}{3}{4}",dots,star,middleDot,star,dots);
            numMiddleDots += 2;
        }
        Console.Write(new string(star,num/2));
        Console.Write(new string(dot,width-num));
        Console.Write(new string(star, num / 2));
        Console.WriteLine();
        for (int i = 0; i < num/2-2; i++)
        {
            Console.WriteLine("{0}{1}{2}",star, new string(dot,width-2),star);
        }
        Console.WriteLine(new string(star,width));
        for (int i = 0; i < num/2-2; i++)
        {
            int widthWheels = num / 2 + 1;
            int widthBetwWheel = width - (2 * widthWheels + num);
            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", new string(dot, num /2), star, new string(dot, widthWheels - 2), star, new string(dot, widthBetwWheel),
                 star, new string(dot, widthWheels - 2), star, new string(dot, num / 2));
        }
        int widthWheel = num/2+1;
         int widthBetw = width - (2 *widthWheel + num);
         Console.WriteLine("{0}{1}{2}{3}{4}", new string(dot, num / 2), new string(star, widthWheel), new string(dot,widthBetw),new string(star, widthWheel) , new string(dot, num / 2));

    }
}

