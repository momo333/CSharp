using System;
//•	Write a program to check if in a given expression the brackets are put correctly.
class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Please enter expression: ");
        string expression = Console.ReadLine();

        int brackets = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                brackets++;
            }
            else if (expression[i] == '(')
            {
                brackets--;
            }
            if (brackets < 0)
            {
                break;
            }
        }
        if(brackets==0)
        {
            Console.WriteLine("Valid input brackets!");
        }
        else
            Console.WriteLine("Invalid expression!");

    }
}

