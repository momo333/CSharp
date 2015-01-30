using System;
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
class Nullvalues
{
    static void Main()
    {
        int? value = null;
        int? valueTwo = null ;

        int? nullMathValue = value + null;
        int? nullMathValueTwo = valueTwo + 5;
        Console.WriteLine(value);
        Console.WriteLine(valueTwo);
        Console.WriteLine(nullMathValue);
        Console.WriteLine(nullMathValueTwo);
    }
}

