using System;
/*•	Write a program that reads an integer number and calculates and prints its square root.
 * o	If the number is invalid or negative, print Invalid number.
   o	In all cases finally print Good bye.
•	Use try-catch-finally block.*/
class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Please enter number: ");
            uint number = uint.Parse(Console.ReadLine());
            double sqrt = Math.Sqrt(number);
            Console.WriteLine(sqrt);
        }
        catch(ArgumentException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch(OverflowException)
        {
            Console.WriteLine("The entered number is not int range!");
        }
        catch(FormatException)
        {
            Console.WriteLine("Not a number! ");
        }
        finally
        {
            Console.WriteLine("END!");
        }
    }
}

