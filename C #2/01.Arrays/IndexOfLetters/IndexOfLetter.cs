using System;
//Problem 12. Index of letters
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array
class Program
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();     //enter with capital letters
        char[] arrayWord = word.ToCharArray();
        char[] arrCapital = {'A', 'B', 'C', 'D', 'E', 'F','G','H', 'I', 'J', 'K', 'L', 'M', 'N', 
                         'O', 'P', 'Q', 'R', 'S', 'T','U', 'V','W','X','Y','Z'};
        char[] arrsmall = {'a', 'b', 'c', 'd', 'e', 'f','g','h', 'i', 'j', 'k', 'l', 'm', 'n', 
                         'o', 'p', 'q', 'r', 's', 't','u', 'v','w','x','y','z'};

        for (int i = 0; i < arrayWord.Length; i++)
        {
            for (int j = 0; j < arrCapital.Length; j++)
            {
                if (arrayWord[i] == arrCapital[j])
                {
                    Console.Write("The index of the letter is: {0} ", j);
                }
                else if (arrayWord[i] == arrsmall[j])
                {
                    Console.Write("The index of the letter is: {0} ", j);
                }
            }
        }

    }
}

