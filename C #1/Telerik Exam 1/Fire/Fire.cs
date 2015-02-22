using System;


namespace Fire
{
    class Fire
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int halfN = number / 2;
            char diez = '#';
            char dot = '.';
            char back = '/';
            char straight = '\\';
            int dotsMid = 0;
            for (int i = 0; i < number/2+1; i++)
            {
                Console.Write(new string(dot, halfN-i));
                Console.Write(new string(diez,1));
                Console.Write(new string(dot, dotsMid));
                Console.Write(new string(diez, 1));
                Console.Write(new string(dot, halfN - i));
                dotsMid += 2;
                Console.WriteLine();
            }
            for (int i = 0; i < number /4; i++)
            {
                Console.Write(new string(dot, i));
                Console.Write(new string(diez, 1));
                Console.Write(new string(dot, number -2*i));
                Console.Write(new string(diez, 1));
                Console.Write(new string(dot, i));
                Console.WriteLine();
            }
            Console.WriteLine(" " + new string('-', number));
            for (int i = 0; i < number/2; i++)
            {
                Console.Write(" " + new string(dot, i));
                Console.Write(new string(straight,halfN-i));
                Console.Write(new string(back,halfN-i));
                Console.Write(new string(dot,i));
                Console.WriteLine();
            }
        }
    }
}
