using System;

class Program
{

    static void Main()
    {
        string number = Console.ReadLine();
        char[] arr = number.ToCharArray();
        int count = 0;
        int sum = 0;
        int size = arr.Length;
        if (number == "0")
        {
            Console.WriteLine(0);
        }
        
        else
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i % 2) != 0)
                {
                    if(char.IsDigit(arr[i]))
                    {
                        count++;
                        int digit = (int)(arr[i] - '0');
                        sum += digit;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.Write(count + " ");
            Console.Write(sum);
        }
    }
}

//else if(arr[0]-'0' < 0)
        //{
        //     if (arr[0] - '0' < 0)
        //    {
        //        for (int i = 0; i < arr.Length - 1; i++)
        //        {
        //            arr[i] = arr[i + 1];
        //        }
        //        size--;	
        //    }
        //}