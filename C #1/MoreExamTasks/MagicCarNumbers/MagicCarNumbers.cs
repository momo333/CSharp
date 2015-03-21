using System;


class MagicCarNumbers
{
    static int count = 0;
    private static int CheckCarNumberForMagic(string carNumbers, int weight)
    {
        int tempweigh=0;
        foreach (var ch in carNumbers)
        {
            if (ch >= '0' && ch <= '9')
            {
                tempweigh += ch - '0';
            }
            else
            {
                tempweigh += (ch - 64) * 10;
            }
        }
        if(tempweigh==weight)
        {
            count++;
        }
        return count;
    }
    static void Main()
    {
        int weight = int.Parse(Console.ReadLine());
        char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        for (int lt1 = 0; lt1 < letters.Length; lt1++)
        {
            for (int lt2 = 0; lt2 < letters.Length; lt2++)
            {
                for (int a = 0; a <=9; a++)
                {
                    string carNumber="CA" + a + a  + a + a + letters[lt1] + letters[lt2];
                    CheckCarNumberForMagic(carNumber, weight);
                    for (int b = 0; b < 9; b++)
                    {
                        if(b!=a)
                        {
                            CheckCarNumberForMagic("CA" + a + b + b + b + letters[lt1] + letters[lt2], weight);
                            CheckCarNumberForMagic("CA" + a + a + a + b + letters[lt1] + letters[lt2], weight);
                            CheckCarNumberForMagic("CA" + a + a + b + b + letters[lt1] + letters[lt2], weight);
                            CheckCarNumberForMagic("CA" + a + b + b + a + letters[lt1] + letters[lt2], weight);
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}

