using System;


namespace LeastMjorityMultiple
{
    class LeastMajorty
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());
            int numFive = int.Parse(Console.ReadLine());
            
            for (int i = 1; true; i++)
            {
                int count=0;
                if (i % numOne == 0)
                {
                    count++;
                }
                if ( i % numTwo  == 0)
                {
                    count++;
                }
                if (i % numThree == 0)
                {
                    count++;
                }
                if (i % numFour == 0)
                {
                    count++;
                }
                if (i % numFive == 0)
                {
                    count++;
                }
                if(count>=3)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
