using System;

class WinningNumbers
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int LenSum = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'A' && str[i] <= 'Z')
            {
                int digit = str[i] - 64;
                LenSum += digit;
            }
            else if (str[i] >= 'a' && str[i] <= 'z')
            {
                int digit = str[i] - 96;
                LenSum += digit;
            }
        }
        int count=0;
        for (int i0 = 0; i0 <= 9; i0++)
        {
            for (int i1 = 0; i1 <= 9; i1++)
            {
                for (int i2 = 0; i2 <= 9; i1++)
                {
                    if(i0*i1*i2==LenSum)
                    {
                        for (int i3 = 0; i3 <= 9; i1++)
                        {
                            for (int i4 = 0; i4 <= 9; i1++)
                            {
                                for (int i5 = 0; i5 <= 9; i1++)
                                {
                                    int product1 = i0*i1*i2;
                                    int product2  =i3*i4*i5;
                                   if(product1==product2) 
                                   {
                                        Console.WriteLine("{0}{1}{2} - {3}{4}{5}",i0,i1,i2,i3,i4,i5);
                                       
                                   }
                                }
                            }
                        }
                    }
                }
            }
        }
        if(count==0)
        {
            Console.WriteLine("No");
        }
    }

}

