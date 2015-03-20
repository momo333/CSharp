using System;


class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        string zeroTopBottom = "###";
        string zeroBody = "#.#";
        string oneTopBody = ".#.";
        string oneUnuqie = "##.";

        string binary = Convert.ToString(number, 2).PadLeft(32, '0');
        for (int row = 0; row < 5; row++)
        {
            for (int bit = 16; bit < binary.Length; bit++)
            {
                if(binary[bit]=='0')
                {
                    if(row==0 || row==4)
                    {
                        Console.Write(zeroTopBottom);
                    }
                    else
                    {
                        Console.Write(zeroBody);
                    }
                }
                else
                {
                    if(row ==0 || row==2 || row ==3)
                    {
                        Console.Write(oneTopBody);
                    }
                    else if(row==1)
                    {
                        Console.Write(oneUnuqie);
                    }
                    else if(row ==4)
                    {
                        Console.Write(zeroTopBottom);
                    }
                }
                if(bit!=binary.Length-1)
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}

