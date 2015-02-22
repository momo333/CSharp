using System;

class AstrologicalDigits
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        int result = SumDigits(number);
        int value = AstrologicalDigit(result);
        Console.WriteLine(value);
    }

    static int AstrologicalDigit(int num)
    {
        if (num > 9)
        {
             return AstrologicalDigit(SumDigits(Convert.ToString(num)));
        }
           
        else
        {
            return Convert.ToInt16(num);
        }
    }


    static int SumDigits(string number)
    {
        int sum = 0;
        foreach(char c in number)
        {
            if(c=='.' || c=='-')
            {
                continue;
            }
            else
                sum += (c - '0');
        }
        return sum;
    }
}


//using System;

//class AstrologicalDigits
//{
//    static void Main(string[] args)
//    {
//        string number = Console.ReadLine();
//        int sumN = 0;

//        char[] nums = number.ToCharArray();
//        int length = nums.Length;
//        for (int i = 0; i < length; i++)
//        {
//            if(char.IsDigit(nums[i]))
//            {
//                int digit = nums[i] - '0';
//                sumN += digit;
//            }
//        }
//       int copy = sumN;      //2222
//       int sumDigN = 0;
//       while(copy>9)
//       {
//           while(copy!=0)
//           {
//               int dig = copy % 10;
//               sumDigN+=dig;
//               copy /= 10;
//           }
//           copy = sumDigN;
//       }
//       Console.WriteLine(copy);
        
//    }
//}



//while(true)
//        {
//            int sumDigits = 0;
//            int next = Console.Read();
//            int ch = Console.Read();
//            {
//                break;
//            }
//            char nextChar = (char)ch;
//            int digit = nextChar - '0';     //ili int digit = int.Parse(nextDigit)
//            sumDigits+=digit;
//        }