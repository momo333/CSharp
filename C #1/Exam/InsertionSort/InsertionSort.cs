using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{

    class InsertionSort
    {
        static void ShiftingNumbers(List<int> lst)
        {
            int N = lst.Count;
            int temp = lst[N - 1];
            for (int i= N - 2; i > 0; i--)
            {
                if(temp<i)
                {
                lst[i] = lst[i + 1];
                for (int j = 0; j < N; j++)
                    {
                        Console.WriteLine(lst[j] + " ");
                    }
                }
                if(temp==lst[i])
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> lst = new List<int>();
            for (int i = 0; i < number; i++)
            {
                int input = int.Parse(Console.ReadLine());
                lst.Add(input);
            }
        }
    }
}
