using System;
using System.Text;

    class Program
{
    static void Main(string[] args)
    {
        StringBuilder result = new StringBuilder();
        string input = Console.ReadLine();
        while (input != "-1")
        {
            uint num = uint.Parse(input);
            char[] bin = Convert.ToString(num, 2).PadLeft(32, '0').ToCharArray();
            int left = 0;
            int right = 0;
            for (int i = 0; i < 32; i++)
            {
                if (bin[i] == '1')
                {
                    left = i;
                    break;
                }
            }
            for (int i = 31; i >= 0; i--)
            {
                if (bin[i] == '1')
                {
                    right = i;
                    break;
                }
            }

            for (int i = 0; i < left; i++)
            {
                bin[i] = '1';
            }
            for (int i = 31; i > right; i--)
            {
                bin[i] = '1';
            }

            if (left == 0 && right == 0)
            {
                for (int i = 0; i < 32; i++)
                {
                    bin[i] = '1';
                }
            }

            num = Convert.ToUInt32(new string(bin), 2);
            num = ~num;
            result.AppendLine(num.ToString());

            input = Console.ReadLine();
        }

        Console.WriteLine(result);
    }
}
