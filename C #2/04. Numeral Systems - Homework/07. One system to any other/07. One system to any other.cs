using System;
//•	Write a program to convert from any numeral system of given base s to any other 
        //  numeral system of base d (2 ≤s, d ≤ 16).
class OneSystemToAnyOther
{
    static void BinaryToOctal()
    {
        string binary = Console.ReadLine();
        int integer = Convert.ToInt32(binary, 2);
        Console.WriteLine(Convert.ToString(integer, 8));
    }
    static void BinaryToHex()
    {
        string strBinary = Console.ReadLine();
        string strHex = Convert.ToInt32(strBinary, 2).ToString("X");
        Console.WriteLine(strHex);
    }
    static void BinaryToDecimal()
    {
        double sum = 0;
        int binary = int.Parse(Console.ReadLine()); // binary number
        int strn = binary.ToString().Length; //how many digits has the number
        for (int i = 0; i < strn; i++)
        {
            int lastDigit = binary % 10; // get the last digit
            sum = sum + lastDigit * (Math.Pow(2, i));
            binary = binary / 10; //remove the last digit
        }
        Console.WriteLine("The Decimal repreentation is: {0}", sum);
    }
    static void Main()
    {
        Console.WriteLine("Convert from numeric system with base: ");
        string s = Console.ReadLine();
        Console.WriteLine("Covert to numeric system: ");
        string d = Console.ReadLine();
        if (s=="2")
        {
             if(d=="8")
            {
                BinaryToOctal();
            }
            else if(d=="10")
            {
                BinaryToDecimal();
            }
            
            else if(d=="16")
            {
                BinaryToHex();
            }
            
        }
        else if(s=="8")
        {

        }
    }
}

