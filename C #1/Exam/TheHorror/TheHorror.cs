using System;


namespace TheHorror
{
    class TheHorror
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            char[] num = number.ToCharArray();
            int lenght = num.Length;
            int count = 0;
            int sum = 0;
            for (int i = 0; i < lenght; i++)
            {
                if((i%2)==0)
                {
                    if(char.IsDigit(num[i]))
                    {
                        count++;
                        int digit = (int)(num[i] -'0');
                        sum +=digit;  
                    }
                }
            }
            Console.WriteLine("{0} {1}", count, sum);
        }
    }
}
