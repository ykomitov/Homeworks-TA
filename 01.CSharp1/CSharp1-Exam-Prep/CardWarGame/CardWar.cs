using System;
using System.IO;

class CardWar
{
    static void Main()
    {
        // StreamReader reader = new StreamReader("..\\..\\sampleinput.txt");

        int n = int.Parse(Console.ReadLine());
        int player1TotalScore = 0;
        int player2TotalScore = 0;
        int player1HandsScore = 0;
        bool player1HasCardX;
        for (int i = 0; i < n; i++)
        {
            //read 1st player cards
            for (int j = 0; j < 3; j++)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "A": player1HandsScore += 1; break;
                    case "K": player1HandsScore += 13; break;
                    case "Q": player1HandsScore += 12; break;
                    case "J": player1HandsScore += 11; break;
                    case "X": player1HasCardX = true; break;
                    case "Y": player1HandsScore -= 200; break;
                    case "Z": break;
                    default: int value = 12 - int.Parse(card); break;
                }
            }
        }
        if (player1TotalScore == player2TotalScore)
        {
            Console.WriteLine("Its a tie!");
        }
        if (player1TotalScore > player2TotalScore)
        {

        }
    }
}
