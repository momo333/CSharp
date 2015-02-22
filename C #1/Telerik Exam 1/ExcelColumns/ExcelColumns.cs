using System;

class ExcelColumns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long result = 0;
        for (int i = 0; i < n; i++)
        {
            result += (Convert.ToChar(Console.ReadLine()) - 64) * (long)Math.Pow(26, n - i - 1);
        }
        Console.WriteLine(result);
    }
}

//using System;
 
//class Excel
//{
//    static void Main()
//    {
//        int length = int.Parse(Console.ReadLine());
//        char mask = '@';
//        long result = 0;
//        for (int i = length - 1; i >= 0; i--)
//        {
//            char input = Console.ReadLine()[0];
//            result += (input-mask)*((long)Math.Pow(26,i));
//        }
//        Console.WriteLine(result);
//    }
//}