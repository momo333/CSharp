using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int numDotsFirst = number - 2;
        int numStar = 1;
        char star = '*';
        char dot = '.';
        int rows = 0;
        while(rows<number)
        {
            string startDots = new string(dot, numDotsFirst);
            string stars = new string(star, numStar);
            Console.Write("{0}{1}{2}",startDots, stars,startDots);
            Console.WriteLine();
            numDotsFirst--;
            if(numDotsFirst<0)
            {
                break;
            }
            numStar+=2;
            rows++;
            
        }
        string bottomDots = new string(dot,number-2);
        string starsBottom = new string(star,1);
        Console.Write("{0}{1}{2}", bottomDots, starsBottom, bottomDots);
    }
}

