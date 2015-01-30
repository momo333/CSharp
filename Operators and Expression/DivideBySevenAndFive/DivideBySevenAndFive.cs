using System;
//Problem 3. Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
class DivideBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("The program calculates if number can be divided by 7 & 5 at the same time");
        int number = int.Parse(Console.ReadLine());

        bool divide = false;
        if (number % 35 ==0)
	        {
                divide = true;
		        Console.WriteLine(divide);
	        }
        else
	        {
                divide = false;
                Console.WriteLine(divide);
	        }
        Console.ReadLine();
    }
}

