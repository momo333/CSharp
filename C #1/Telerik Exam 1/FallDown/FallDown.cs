using System;
using System.Text;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        int[,] matrix = new int[8, 8];
        for (int row = 0; row < 8; row++)
        {
            int num = int.Parse(Console.ReadLine());
            string numToString = Convert.ToString(num, 2).PadLeft(8, '0');
            for (int col = 0; col < 8; col++)
            {
                matrix[row, col] = int.Parse(numToString[col].ToString());
            }

        }
        for (int col = 0; col < 8; col++)
        {
            int[] temp = new int[8];
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 1)
                {
                    temp[row] = 1;
                }
            }
            Array.Sort(temp);
            for (int i = 0; i < 8; i++)
            {
                matrix[7 - i, col] = temp[7 - i];
            }
        }

    }
}

//using System;
//using System.Text;
//using System.Globalization;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {

//        int[,] matrix = new int[8, 8];
//        for (int row = 0; row < 8; row++)
//        {
//            int num = int.Parse(Console.ReadLine());
//            string numToString = Convert.ToString(num, 2).PadLeft(8, '0');
//            for (int col = 0; col < 8; col++)
//            {
//                matrix[row, col] = int.Parse(numToString[col].ToString());
//            }

//        }
//        for (int col = 0; col < 8; col++)
//        {
//            int count = 0;
//            for (int row = 0; row < 8; row++)
//            {
//                if(matrix[row,col]==1)
//                {
//                    count++;
//                    matrix[row, col] = 0;
//                }
//                for (int i = 0; i < count; i++)
//                {
//                   matrix[7-i,col] =1;
//                }
//            }
//            //Output
//        }
//        for (int row = 0; row < 8; row++)
//        {
//            StringBuilder sb = new StringBuilder();
//            for (int col = 0; col < 8; col++)
//            {
//                sb.Append(matrix[row, col]);
//            }
//            int num = Convert.ToInt32(sb.ToString(), 2);
//            Console.WriteLine(num);
//        }
//    }
//}


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {

//        int[] nums = new int[8];
//        for (int i = 0; i < 8; i++)
//        {
//            nums[i] = int.Parse(Console.ReadLine());
//                for (int line = 7; line >=0; line--)
//            {
//             for (int bitPos = 0; bitPos< 8; bitPos++)
//            {
//                if((nums[line]>>bitPos&1)==0 && 
//                    ((nums[line-1]>>bitPos&1)==1))
//                {
//                    nums[line] |= 1<<bitPos;
//                    nums[line - 1] = 1 << bitPos;
//                }
//            }
//            }
//            foreach(var num in nums)
//            {
//                Console.WriteLine(nums[i]);
//            }
//        }
//    }
//}




//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int num0 = int.Parse(Console.ReadLine());
//        int num1 = int.Parse(Console.ReadLine());
//        int num2 = int.Parse(Console.ReadLine());
//        int num3 = int.Parse(Console.ReadLine());
//        int num4 = int.Parse(Console.ReadLine());
//        int num5 = int.Parse(Console.ReadLine());
//        int num6 = int.Parse(Console.ReadLine());
//        int num7 = int.Parse(Console.ReadLine());

//        for (int i = 0; i < 7; i++)
//        {
//            for (int bitPos = 0; bitPos < 8; bitPos++)
//            {
//                int mask = 1;
//                if (((num7 >> bitPos) & mask) == 0 &&
//                    (num6 >> bitPos & 1) == 1)
//                {
//                    num7 |= (1 << bitPos);
//                    num6 ^= (1 << bitPos);
//                }
//            }
//            for (int bitPos = 0; bitPos < 8; bitPos++)
//            {
//                int mask = 1;
//                if (((num6 >> bitPos) & mask) == 0 &&
//                    (num5 >> bitPos & 1) == 1)
//                {
//                    num6 |= (1 << bitPos);
//                    num5 ^= (1 << bitPos);
//                }
//            }
//            for (int bitPos = 0; bitPos < 8; bitPos++)
//            {
//                int mask = 1;
//                if (((num5 >> bitPos) & mask) == 0 &&
//                    (num4 >> bitPos & 1) == 1)
//                {
//                    num5 |= (1 << bitPos);
//                    num4 ^= (1 << bitPos);
//                }
//            }
//            for (int bitPos = 0; bitPos < 8; bitPos++)
//            {
//                int mask = 1;
//                if (((num4 >> bitPos) & mask) == 0 &&
//                    (num3 >> bitPos & 1) == 1)
//                {
//                    num4 |= (1 << bitPos);
//                    num3 ^= (1 << bitPos);
//                }
//            }
//            for (int bitPos = 0; bitPos < 8; bitPos++)
//            {
//                int mask = 1;
//                if (((num3 >> bitPos) & mask) == 0 &&
//                    (num2 >> bitPos & 1) == 1)
//                {
//                    num3 |= (1 << bitPos);
//                    num2 ^= (1 << bitPos);
//                }
//            }
//            for (int bitPos = 0; bitPos < 8; bitPos++)
//            {
//                int mask = 1;
//                if (((num2 >> bitPos) & mask) == 0 &&
//                    (num1 >> bitPos & 1) == 1)
//                {
//                    num2 |= (1 << bitPos);
//                    num1 ^= (1 << bitPos);
//                }
//            }
//            for (int bitPos = 0; bitPos < 8; bitPos++)
//            {
//                int mask = 1;
//                if (((num1 >> bitPos) & mask) == 0 &&
//                    (num0 >> bitPos & 1) == 1)
//                {
//                    num1 |= (1 << bitPos);
//                    num0 ^= (1 << bitPos);
//                }
//            }
//        }

//        Console.WriteLine(num0);
//        Console.WriteLine(num1);
//        Console.WriteLine(num2);
//        Console.WriteLine(num3);
//        Console.WriteLine(num4);
//        Console.WriteLine(num5);
//        Console.WriteLine(num6);
//        Console.WriteLine(num7);
//    }
//}
