using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
/*•	Write a program that encodes and decodes a string using given encryption key (cipher).
          •	The key consists of a sequence of characters.
          •	The encoding/decoding is done by performing XOR (exclusive or) operation over the first 
         * letter of the string with the first of the key, the second – with the second, etc. When 
         * the last key character is reached, the next is the first.*/
class EncodeDecode
{
    static string EncryptOrDecrypt(string text, string key)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            char letter = text[i];          
            int code = (int)(letter);
            int positionKey = i % key.Length;               //when the last char is reached we go back to the first again
            char keyChar = key[positionKey];
            int keyCode = (int)keyChar;
            int twistedCode = positionKey ^ keyCode;
            char twistedChar = (char)twistedCode;
            result.Append(twistedChar);
        }
        return result.ToString(); 
    }
    static void Main()
    {
        Console.WriteLine("Please enter text:");
        string text = Console.ReadLine();
        string key = Console.ReadLine();
        Console.WriteLine("Choose one for encryption and 2 for decryption: ");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("Encryped text");
                Console.WriteLine(EncryptOrDecrypt(text, key));
                break;
            case 2:
                Console.WriteLine("Encryped text");
                Console.WriteLine(EncryptOrDecrypt(EncryptOrDecrypt(text, key), key));
                break;
        }




    }
}
