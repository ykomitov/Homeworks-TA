using System;

// You are given a number (SECRET) and a text. The text must be encoded using the SECRET.
// •    If the character is “@”, stop the program
// •    If the character in the text is a letter, multiply its char code by the given SECRET and add 1000.
// •    If the character in the text is a digit, add to its char code SECRET and add 500
// •    If the character in the text is not a digit, letter or “@” (any other symbol), subtract from its char code SECRET
// •    After performing the above operations on the character in the original text:
//   o    If the character is on even position in the text - divide the encoded value by 100 and round the precision to 2 digits after the decimal point
//   o    Else if the character is on odd position in the original text – multiply its encoded value by 100
//   o    The first character in the text is at position 0. 
public class SymbolToNum
{
    public static void Main()
    {
        byte secret = byte.Parse(Console.ReadLine());
        string inputTxt = Console.ReadLine();

        bool continueEncoding = true;

        do
        {
            int encodedValue = 0;
            decimal result;

            for (int i = 0; i < inputTxt.Length; i++)
            {
                char currentSymbol = inputTxt[i];

                bool isLowerOrUppercaseLetter = (currentSymbol >= 65 && currentSymbol <= 90) ||
                                                (currentSymbol >= 97 && currentSymbol <= 122);
                bool isDigit = currentSymbol >= 48 && currentSymbol <= 57;
                bool isAT = currentSymbol == 64;
                bool onEvenPosition = i % 2 == 0;

                // Encoding logic
                if (isLowerOrUppercaseLetter)
                {
                    encodedValue = (inputTxt[i] * secret) + 1000;
                }
                else if (isDigit)
                {
                    encodedValue = inputTxt[i] + secret + 500;
                }
                else if (!isAT)
                {
                    encodedValue = inputTxt[i] - secret;
                }
                else
                {
                    continueEncoding = false;
                }

                // Print the result on the console
                if (onEvenPosition && continueEncoding)
                {
                    result = encodedValue / 100M;
                    Console.WriteLine("{0:0.00}", result);
                }
                else if (!onEvenPosition && continueEncoding)
                {
                    result = encodedValue * 100M;
                    Console.WriteLine(result);
                }
            }
        }
        while (continueEncoding);
    }
}
