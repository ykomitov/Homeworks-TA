using System;
using System.Linq;
using System.Numerics;


class Program03
{
    static void Main()
    {
        //StreamReader reader = new StreamReader("..\\..\\input.txt");
        //Console.SetIn(reader);

        string line;
        string input = "";
        string digitsString = "";
        BigInteger digitsProduct = 1;
        BigInteger digitsProduct2 = 1;

        while ((line = Console.ReadLine()) != "END")
        {
            input = input + " " + line;
        }
        string[] arrayInput = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        if (arrayInput.Length <= 10)
        {
            for (int i = 0; i < arrayInput.Length; i++)
            {
                if (i % 2 == 0)
                {
                    digitsString = arrayInput[i];
                    if (digitsString == "48")
                    {
                        digitsProduct *= 1;
                    }
                    else
                    {
                        for (int j = 0; j < digitsString.Length; j++)
                        {
                            if (digitsString[j] != '0')
                            {
                                digitsProduct *= Convert.ToInt32(digitsString[j] - '0');
                            }
                        }
                    }
                }
            }
            Console.WriteLine(digitsProduct);
        }
        else if (arrayInput.Length > 10)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    digitsString = arrayInput[i];
                    if (digitsString == "48")
                    {
                        digitsProduct *= 1;
                    }
                    else
                    {
                        for (int j = 0; j < digitsString.Length; j++)
                        {
                            if (digitsString[j] != '0')
                            {
                                digitsProduct *= Convert.ToInt32(digitsString[j] - '0');
                            }
                        }
                    }
                }
            }
            Console.WriteLine(digitsProduct);
            
            for (int i = 10; i < arrayInput.Length; i++)
            {
                if (i % 2 == 0)
                {
                    digitsString = arrayInput[i];
                    if (digitsString == "48")
                    {
                        digitsProduct2 *= 1;
                    }
                    else
                    {
                        for (int j = 0; j < digitsString.Length; j++)
                        {
                            if (digitsString[j] != '0')
                            {
                                digitsProduct2 *= Convert.ToInt32(digitsString[j] - '0');
                            }
                        }
                    }
                }
            }
            Console.WriteLine(digitsProduct2);
        }
    }
}
