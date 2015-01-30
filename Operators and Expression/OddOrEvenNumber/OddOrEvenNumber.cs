using System;
//Write an expression that checks if given integer is odd or even.

class OddOrEvenNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n % 2 ==0 )
        {
            Console.WriteLine("The number is even ");
        }
        else if (n % 2 !=0)
        {
            Console.WriteLine("The number is odd");
        }
        else
        {
            Console.WriteLine("The number is Zero");
        }
    }
}

