using System;
using System.Numerics;


class Program
{
    static void Main()
    {
        int allGames = int.Parse(Console.ReadLine());   //games in a match
        const int cardInGame = 3;
        BigInteger globalPlayerScoreOne = 0;
        BigInteger globalPlayerScoreTwo = 0;
        bool xcardDrawnbyPlayerOne = false;
        bool xcardDrawnbyPlayerTwo = false;
        int gamesWonbyPlayerOne = 0;
        int gamesWonbyPlayerTwo = 0;
        for (int i = 0; i < allGames; i++)
        {
            int playerLocalScoreOne =0;
            int playerLocalScoreTwo =0;
            for (int j = 0; j < cardInGame; j++)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "J": playerLocalScoreOne+=11; 
                        break;
                    case "Q": playerLocalScoreOne+=12; 
                        break;
                    case "K":playerLocalScoreOne+=13; 
                        break;
                    case "Z": playerLocalScoreOne *=2; 
                        break;
                    case "Y": playerLocalScoreOne += 200; 
                        break;
                    case "X":xcardDrawnbyPlayerOne=true; 
                        break;
                    default: playerLocalScoreOne += 12 - int.Parse(card);
                        break;
                }
            }
            for (int j = 0; j < cardInGame; j++)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "J": playerLocalScoreTwo += 11;
                        break;
                    case "Q": playerLocalScoreTwo += 12;
                        break;
                    case "K": playerLocalScoreTwo += 13;
                        break;
                    case "Z": playerLocalScoreTwo *= 2;
                        break;
                    case "Y": playerLocalScoreTwo += 200;
                        break;
                    case "X": xcardDrawnbyPlayerTwo = true;
                        break;
                    default: playerLocalScoreTwo += 12 - int.Parse(card);
                        break;
                }
            }
            if(xcardDrawnbyPlayerOne && xcardDrawnbyPlayerTwo)
            {
                globalPlayerScoreOne += 50;
                globalPlayerScoreTwo += 50;
                xcardDrawnbyPlayerOne = false;
                xcardDrawnbyPlayerTwo = false;
            }
            if(xcardDrawnbyPlayerOne)
            {
                break;
            }
            else if(xcardDrawnbyPlayerTwo)
            {
                break;
            }
            if (xcardDrawnbyPlayerOne)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
            }
            else if (xcardDrawnbyPlayerTwo)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
            }
            if(playerLocalScoreOne>playerLocalScoreTwo)
            {
                globalPlayerScoreOne += globalPlayerScoreOne;
                    gamesWonbyPlayerOne++;
            }
            else if(playerLocalScoreOne<playerLocalScoreTwo)
            {
                globalPlayerScoreTwo += globalPlayerScoreTwo;
                gamesWonbyPlayerTwo++;
            }
            if(globalPlayerScoreOne>globalPlayerScoreTwo)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score {0}",globalPlayerScoreOne);
                Console.WriteLine("Games won: {0}", gamesWonbyPlayerOne);
            }
            else if (globalPlayerScoreOne < globalPlayerScoreTwo)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score {0}", globalPlayerScoreTwo);
                Console.WriteLine("Games won: {0}", gamesWonbyPlayerTwo);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score {0}", globalPlayerScoreTwo);
            }
            
        }
    }
}

