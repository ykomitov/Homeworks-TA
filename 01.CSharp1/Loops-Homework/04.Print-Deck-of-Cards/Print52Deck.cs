using System;

/*	Write a program that generates and prints all possible cards from a [standard deck of 52 cards](http://en.wikipedia.org/wiki/Standard_52-card_deck) (without the jokers).
	The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
	*	The card faces should start from 2 to A.
	*	Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
	Use 2 nested for-loops and a switch-case statement.
	
_output_

	2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
	3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
	â€¦  
	K of spades, K of clubs, K of hearts, K of diamonds
	A of spades, A of clubs, A of hearts, A of diamonds

_Note: You may use the suit symbols instead of text._*/

class Print52Deck
{
    static void Main()
    {
        char pad = ' ';
        string card = "";
        string suit = "";

        //Loop to iterate through the 13 different card combinations
        for (int a = 2; a < 15; a++)
        {
            //switch statement for converting number cards to string and printing out honours properly
            switch (a)
            {
                case 11:
                    card = "J";
                    break;
                case 12:
                    card = "Q";
                    break;
                case 13:
                    card = "K";
                    break;
                case 14:
                    card = "A";
                    break;
                default:
                    card = Convert.ToString(a);
                    break;
            }

            //Loop to iterate through the four suits
            for (int i = 0; i <= 3; i++)
            {
                switch (i)
                {
                    case 0:
                        suit = " of clubs, ";
                        break;
                    case 1:
                        suit = " of diamonds, ";
                        break;
                    case 2:
                        suit = " of hearts, ";
                        break;
                    case 3:
                        suit = " of spades\r\n";
                        break;
                }
                Console.Write("{0}{1}", card.PadLeft(2, pad), suit); //pad card string to align output
            }
        }
    }
}
