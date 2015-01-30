using System;
//Problem 4. Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("The program shows the sign of the product of three numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a * b * c < 0)
        {
            Console.WriteLine("-");
        }
        else if (a * b * c > 0)
        {
                Console.WriteLine("+");
        }
        else if (a * b * c == 0)
        {
            Console.WriteLine("0");
        }
    }
}

