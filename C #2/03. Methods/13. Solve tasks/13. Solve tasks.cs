using System;
/*•	Write a program that can solve these tasks:
           o	Reverses the digits of a number
           o	Calculates the average of a sequence of integers
           o	Solves a linear equation a * x + b = 0
         •	Create appropriate methods.
         •	Provide a simple text-based menu for the user to choose which task to solve.
         •	Validate the input data:
           o	The decimal number should be non-negative
           o	The sequence should not be empty
           o	a should not be equal to 0*/
class SolveTasks
{
    static void EquationInput()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("A must not be equal to Zero!");
        }
        else
        {
            Console.WriteLine("Equation result is: {0}", CalcEquation(a, b));
        }
    }

    static double CalcEquation(int a, int b)
    {
        return (double)-b / a;
    }
    static void ReverseInt()
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int result = 0;
        while (number > 0)
        {
            result = result * 10 + number % 10;
            number /= 10;
        }
       Console.WriteLine("The revered number is: {0}", result);
    }
    static void FindAverage()
    {
        Console.WriteLine("Please enter size of the sequence: ");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the elements if the sequance: ");
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double average = sum / size;
        Console.WriteLine("The average number is: {}", average);
    }
    static void Main()
    {
        Console.WriteLine("Please choose a option:");
        Console.WriteLine("1. Reverse a number:");
        Console.WriteLine("2. Find average of equence:");
        Console.WriteLine("3. Solve a equation: ");
        string option = Console.ReadLine();
        switch (option)
        {
            case "1":
                ReverseInt();
                break;

            case "2":
                FindAverage();
                break;
            case "3":
                Console.WriteLine("Please enter a ");
                EquationInput();
                break;
            default: Console.WriteLine("Invalid input, enter option 1,2 or 3;");
                break;
        }
    }
}

