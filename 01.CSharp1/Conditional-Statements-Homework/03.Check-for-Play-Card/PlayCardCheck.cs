using System;

/*	Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints "yes" if it is a valid card sign or "no" otherwise. Examples:

| character | Valid card sign? |
|-----------|------------------|
| 5         | yes              |
| 1         | no               |
| Q         | yes              |
| q         | no               |
| P         | no               |
| 10        | yes              |
| 500       | no               |*/

class PlayCardCheck
{
    static void Main()
    {
        string validCard = "No";

        //Initialize an array cardDeck, holding all card symbols
        string[] cardDeck = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        //Read string from console
        Console.Write("Please enter a symbol: ");
        string symbol = Console.ReadLine();

        //Check if enterned symbol exsists whithin the array cardDeck
        for (int i = 0; i < cardDeck.Length; i++)
        {
            if (cardDeck[i] == symbol)
            {
                validCard = "Yes";
            }
        }
        Console.WriteLine("\r\nValid card sign? {0}", validCard);
    }
}
