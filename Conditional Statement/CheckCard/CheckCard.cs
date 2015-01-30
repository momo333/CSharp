using System;

//Problem 3. Check for a Play Card
//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
class CheckCard
{
    static void Main()
    {
        Console.WriteLine("Check given card  - please enter a card:");
        string playCard = Console.ReadLine();
        string[] cards = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };


        bool newCard = false;
        foreach (string card in cards)     
        {
            if (card == playCard)    //check if the given card is in the decade if cards
            {
                newCard = true;     //if it's true then we have a match
                break;
            }
        }

        if (newCard == true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}

