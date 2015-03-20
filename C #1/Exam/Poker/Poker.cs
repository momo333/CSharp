
using System;
					
public class Program
{
	public static void Main()
    {
		int[] cards = new int[13];
		int pairs = 0;
		string hand = "Nothing";
		
		for (int i = 0; i < 5; i++)
		{
			string card = Console.ReadLine();
            switch (card)
            {
                case "A": cards[0]++; break;
                case "2": cards[1]++; break;
                case "3": cards[2]++; break;
                case "4": cards[3]++; break;
                case "5": cards[4]++; break;
                case "6": cards[5]++; break;
                case "7": cards[6]++; break;
                case "8": cards[7]++; break;
                case "9": cards[8]++; break;
                case "10": cards[9]++; break;
                case "J": cards[10]++; break;
                case "Q": cards[11]++; break;
                case "K": cards[12]++; break;
            }
		}
		
		for (int i = 0; i < cards.Length; i++)
		{
			if (cards[i] == 2)
			{
				pairs++;
			}
		}
		
		for (int i = 0; i < cards.Length; i++)
		{
			if (cards[i] == 5)
			{
				hand = "Impossible";
			}
			
			if (cards[i] == 4)
			{
				hand = "Four of a Kind";
			}            
			
			if (cards[i] == 3)
			{
				hand = "Three of a Kind";
			}
			
			if (cards[i] == 2)
			{
				hand = "One Pair";
			}
			
			if (pairs == 2)
			{
				hand = "Two Pairs";
			}
			
			if (cards[i] == 3 && pairs == 1)
			{
				hand = "Full House";
				break;
			}
		}
		
		for (int i = 0; i <= 8; i++)
		{
			if (
				cards[i] == 1 &&
				cards[i + 1] == 1 &&
				cards[i + 2] == 1 &&
				cards[i + 3] == 1 &&
				cards[i + 4] == 1
			)
			{
				hand = "Straight";   
			}
		}
		
		if (
			cards[0] == 1 &&
			cards[9] == 1 &&
			cards[10] == 1 &&
			cards[11] == 1 &&
			cards[12] == 1
		)
		{
			hand = "Straight";
		}
		
		Console.WriteLine(hand);
	}
}