using System;
using System.Numerics;

public class Program03
{
    public static void Main()
    {
        string line;

        BigInteger productOfFirst10 = 1;
        BigInteger productAfterFirst10 = 1;

        int counter = 0;
        while ((line = Console.ReadLine()) != "END")
        {
            char currentDigit;
            BigInteger tempProductOfDigits = 1;

            if (counter % 2 == 0)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    currentDigit = line[i];

                    if (currentDigit != '0')
                    {
                        tempProductOfDigits *= currentDigit - '0';
                    }
                }
            }

            if (counter < 10)
            {
                productOfFirst10 *= tempProductOfDigits;
            }
            else
            {
                productAfterFirst10 *= tempProductOfDigits;
            }

            counter++;
        }

        Console.WriteLine(productOfFirst10);

        if (counter > 10)
        {
            Console.WriteLine(productAfterFirst10);
        }
    }
}