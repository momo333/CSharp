using System;


namespace TrippleRotation
{
    class TrippleRotation
    {

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number > 9)
            {
                for (int i = 0; i < 3; i++)
                {
                    int lastDgit = number % 10;
                    number /= 10;

                    string result = lastDgit.ToString() + number.ToString();
                    number = int.Parse(result);
                }
                Console.WriteLine(number);
            }
        }
    }
}
        


        //static int Length(double number)
        //{
        //    number = Math.Abs(number);
        //    int length = 1;
        //    while ((number /= 10) >= 1)
        //        length++;
       
        //   return length;
        //}

        //static void Main()
        //{
        //    int number = int.Parse(Console.ReadLine());
        //    int copyNum = number;
        //    int digitsLength = Length(number);
           
        //    if(number<10)
        //    {
        //        Console.WriteLine(number);
        //    }
        //                                         //354
        //     int remainder = number % 10;   //4
        //     int restNumber = copyNum / 10;   ///35  --->> 
        //     int newNumberOne;                                 ///300
        //    if(remainder==0)
        //    {
        //        newNumberOne = restNumber;
        //    }
        //    else
        //    {
        //     newNumberOne = remainder * (int)Math.Pow(10,(digitsLength - 1)) + restNumber;  //4*100 + 35 =435   /10
        //    }
            

        //    int newNumberTwo;
        //     int remainderTwo = newNumberOne % 10;
        //     restNumber = newNumberOne / 10;
        //    if(remainderTwo==0)
        //    {
        //        newNumberTwo = restNumber;
        //    }
        //    else
        //    {
        //    newNumberTwo = remainderTwo * (int)Math.Pow(10, (digitsLength - 1)) + restNumber;   //10
        //    }

        //    int newNumberThree;
        //    if (newNumberTwo < 10)
        //    {
        //        Console.WriteLine(newNumberTwo);
        //    }
        //    else
        //    {
        //        int remainderThree = newNumberTwo % 10;
        //        restNumber = newNumberTwo / 10;

        //        if (remainderThree == 0)
        //        {
        //            newNumberThree = restNumber;
        //        }
        //        else
        //        {
        //            newNumberThree = remainderThree * (int)Math.Pow(10, (digitsLength - 1)) + restNumber;
        //        }

        //        Console.WriteLine(newNumberThree);
