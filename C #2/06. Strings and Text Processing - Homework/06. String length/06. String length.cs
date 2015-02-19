using System;
 /*•	Write a program that reads from the console a string of maximum 20 characters. If the 
         * length of the string is less than 20, the rest of the characters should be filled with *.
         •	Print the result string into the console.*/
class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] array = input.ToCharArray();
        if(input.Length>20)
        {
            for (int i = 20; i < input.Length; i++)
            {
                array[i] = '*';
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}
