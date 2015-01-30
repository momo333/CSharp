using System;

//Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

class FloatorDouble
{
    static void Main()
    {
        double valueOne = 34.567839023d;     //can be assigned to double
        float valueTwo = 12.345f;             //can be assigned to float
        double valueThree = 8923.1234857d;    //can be assigned to double
        float valueFour = 3456.091f;            //can be assigned to float
        Console.WriteLine(valueOne);
        Console.WriteLine(valueTwo);
        Console.WriteLine(valueThree);
        Console.WriteLine(valueFour);
    }
}

