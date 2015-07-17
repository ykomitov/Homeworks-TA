// You are given a list of N numbers and a number S.
// Count the occurrences of the most right 5 bits of S in the most right 29 bits in every given number.
// For example there are 3 occurrences of the 5 most right bits of 9 in the number 9369.
// The 5 most right bits of 9 are 01001 and the 29 most right bits in the number 9369 are 00000000000000010010010011001.
// The occurrences are:
// • 00000000000000 01001 0010011001
// • 00000000000000010 01001 0011001
// • 00000000000000010010 01001 1001
using System;
using System.Collections.Generic;

public class Program05
{
    public static void Main()
    {
        byte s = byte.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        string bitsSequence = Convert.ToString(s, 2).PadLeft(5, '0');
        int occurancesCount = 0;

        List<string> listOfBitwiseStrings = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            string lineBit = Convert.ToString(Convert.ToInt32(line), 2).PadLeft(29, '0');
            listOfBitwiseStrings.Add(lineBit);
        }

        for (int i = 0; i < listOfBitwiseStrings.Count; i++)
        {
            string currentNumber = listOfBitwiseStrings[i];
            int endIndex = currentNumber.Length - bitsSequence.Length;

            for (int j = 0; j <= endIndex; j++)
            {
                if (currentNumber.Substring(j, bitsSequence.Length) == bitsSequence)
                {
                    occurancesCount++;
                }
            }
        }

        Console.WriteLine(occurancesCount);
    }
}
