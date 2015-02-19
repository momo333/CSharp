using System;
//•	Write a program that reverses the words in given sentence.
class ReverseSentence
{
    static void Main()
    {
        string expression = Console.ReadLine();
        string[] splitArray = expression.Split(' ');
        int length = splitArray.Length;
        for (int i =length-1 ; i>=0; i--)
        {
            Console.Write(splitArray + " ");
        }
        Console.WriteLine();
    }
}

