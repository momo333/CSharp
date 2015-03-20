using System;



class UnDownGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Up-down game :)");
        Console.WriteLine("Guess my number: ");
        int minimum = 1;
        int maximum = 100;
        Random generator = new Random();
        int endGameNumber = generator.Next(1,101);

        while(true)
        {
            Console.WriteLine("Enter yor number betweem {0} - {1}: ",0, 100);
            int userNumber = int.Parse(Console.ReadLine());
            if(userNumber ==endGameNumber)
            {
                Console.WriteLine("Congratulations! You won : ) ");
                break;
            }
            else if(userNumber>endGameNumber)
            {
                maximum = userNumber -1;
                Console.WriteLine("Down down !!!");
            }
            else if(userNumber<endGameNumber)
            {
                minimum = userNumber + 1;
                Console.WriteLine("Up up !!!");
            }
            
        }
    }
}

