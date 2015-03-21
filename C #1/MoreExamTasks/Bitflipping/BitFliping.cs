using System;



class Program
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        ulong mask = 7;   //111
        int n = 61;
        for (int i = n; i >= 0; i--)
        {
        ulong checker = mask << i;
        checker = checker & number;
        checker = checker >> i; 
            if(checker==7 || checker==0)
            {
                number = number ^ (mask << i);
                i -= 2;
            }
           
        }
        
    }
}

