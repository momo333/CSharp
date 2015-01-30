using System;
//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.
class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.WriteLine("The program shows if the third digit of number is 7");
        int number = int.Parse(Console.ReadLine());
        int check = (number /100)%10;

        if (check == 7)
        {
            Console.WriteLine("The number is seven");
        }
        else
        {
            Console.WriteLine("The number is not seven");
        }
    }
}


