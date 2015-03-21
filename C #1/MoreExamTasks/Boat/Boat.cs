using System;


namespace Boat
{
    class Boat
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int width = number * 2;
            int height = number + 1;
            int starStart = 1;
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                    string star = new string('*', starStart);
                    string dotsStart = new string('.', number - starStart);
                    string dots = new string('.', number);
                    Console.WriteLine("{0}{1}{2}", dotsStart, star, dots);

                if (count <= (number / 2) && (starStart<=number-2))
                {
                    starStart += 2;
                }
                else
                {
                    starStart -= 2;
                }
                count++;
            }
            int boatHeight = number / 2;
            int boatWidth = 2*number;
            int dot = 0;
            for (int i = 0; i < boatHeight; i++)
            {
                Console.Write(new string('.', dot));
                Console.Write(new string('*', boatWidth));
                Console.WriteLine(new string('.', dot));

                boatWidth -= 2;
                dot++;
            }
        }
    }
}
