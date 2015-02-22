using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int guessNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        bool founNum = false;
        for (int i = 1000; i <9999; i++)
        {
            int currentBulls = 0;
            int currentCows = 0;
            int currNum = i;
            int currNum4 = currNum % 10;
            currNum /= 10;
            int currNum3 = currNum % 10;
            currNum /= 10;
            int currNum2 = currNum % 10;
            currNum /= 10;
            int currNum1 = currNum % 10;

            if(currNum1==0 ||currNum2==0||currNum3==0 || currNum4==0)
            {
                continue;
            }
            int tempGuessNum = guessNumber;
            int guessNum4 = tempGuessNum % 10;
            tempGuessNum /= 10;
            int guessNum3 = tempGuessNum % 10;
            tempGuessNum /= 10;
            int guessNum2 = tempGuessNum % 10;
            tempGuessNum /= 10;
            int guessNum1 = tempGuessNum % 10;
            
            if(currNum1==guessNum1)
            {
                currentBulls++;
                currNum1 = -1;
                guessNum1 = -1;
            }
            if (currNum2 == guessNum2)
            {
                currentBulls++;
                currNum2 = -1;
                guessNum2 = -1;
            }
            if (currNum3 == guessNum3)
            {
                currentBulls++;
                currNum3 = -1;
                guessNum3 = -1;
            }
            if (currNum4 == guessNum4)
            {
                currentBulls++;
                currNum4 = -1;
                guessNum4 = -1;
            }

            var list = new List<int>();
            if (currNum1 > 0)
                list.Add(currNum1);
            if (currNum2 > 0)
                list.Add(currNum1);
            if (currNum3 > 0)
                list.Add(currNum1);
            if (currNum4 > 0)
                list.Add(currNum1);
            if(list.Contains(guessNum1))
            {
                list.Remove(guessNum1);
                currentCows++;
            }
            if (list.Contains(guessNum2))
            {
                list.Remove(guessNum2);
                currentCows++;
            }
            if (list.Contains(guessNum3))
            {
                list.Remove(guessNum3);
                currentCows++;
            }
            if (list.Contains(guessNum4))
            {
                list.Remove(guessNum4);
                currentCows++;
            }

            if(currentBulls==bulls && currentCows==cows)
            {
                founNum = true;
                Console.Write("{0}", i);
            }
        }
        if(!founNum)
        {
            Console.WriteLine("No");
        }
        else
            Console.WriteLine();
    }
}

