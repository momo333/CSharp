using System;

class Program
{
    static void Main(string[] args)
    {
        byte number = byte.Parse(Console.ReadLine());
        int[] numbers = new int[number];
        int leftDiagCounter =0;
        int rightDiagCounter =0;
        int vertCounter = 0;
        for (int i = 0; i < 8; i++)
        {
            int topNum = numbers[i];
            int bottomNum = numbers[i + 1];
            int readNumber = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                int mask = 1 << j;
                bool checkBit = (topNum&mask)>0;
                if (checkBit && (bottomNum & (mask >> 1)) > 0)
                    rightDiagCounter++;
                if (checkBit && (bottomNum & (mask << 1)) > 0)
                    leftDiagCounter++;
                if (checkBit && (bottomNum & mask) > 0)
                    vertCounter++;
            }
        }
        Console.WriteLine(rightDiagCounter);
        Console.WriteLine(leftDiagCounter);
        Console.WriteLine(vertCounter);
    }
}

