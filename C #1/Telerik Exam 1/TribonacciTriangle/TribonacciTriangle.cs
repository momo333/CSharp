using System;


class Program
{
    static void Main(string[] args)
    {
        long numberOne = long.Parse(Console.ReadLine());
        long numberTwo = long.Parse(Console.ReadLine());
        long numberThree = long.Parse(Console.ReadLine());
        int numberLines = int.Parse(Console.ReadLine());
        int lines=3;
        int numbersRow = 1;
        long nextNumber = 0; ;
        Console.WriteLine(numberOne);
        
        Console.Write("{0} {1}", numberTwo, numberThree);
        Console.WriteLine();
        

        while(lines<=numberLines)
        {
           
            nextNumber = numberOne + numberTwo + numberThree;
            numberOne = numberTwo;
            numberTwo = numberThree;
            numberThree = nextNumber;
            Console.Write(nextNumber + " ");
            numbersRow++;
           if(numbersRow>lines)
           {
               Console.WriteLine();
               lines++;
               numbersRow = 1;
           }
        }

    }
}

