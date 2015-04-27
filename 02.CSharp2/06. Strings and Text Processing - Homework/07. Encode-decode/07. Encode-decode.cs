/*Write a program that encodes and decodes a string using given encryption key (cipher).
  The key consists of a sequence of characters.
  The encoding/decoding is done by performing XOR (exclusive or) operation over the first 
  letter of the string with the first of the key, the second – with the second, etc. When 
  the last key character is reached, the next is the first.*/

using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        Console.Write("Please enter a string to encode: ");
        string input = Console.ReadLine();
        string key = "Inamorata";

        Console.WriteLine("\r\nOriginal:\r\n{0}", input);
        string encoded = EncDec(input, key);
        
        Console.WriteLine("\r\nEncoded:\r\n{0}", encoded);
        Console.WriteLine("\r\nDecoded:\r\n{0}", EncDec(encoded, key));
    }
    static string EncDec(string input, string key)
    {
        int[] resultArr = new int[input.Length];
        StringBuilder sb = new StringBuilder();

        for (int i = 0, j = 0; i < input.Length; i++, j++)
        {
            if (j < key.Length - 1)
            {
                resultArr[i] = ((int)input[i]) ^ ((int)key[j]);
                sb.Append(Convert.ToChar(resultArr[i]));
            }
            else
            {
                resultArr[i] = ((int)input[i]) ^ ((int)key[j]);
                sb.Append(Convert.ToChar(resultArr[i]));
                j = -1; //Reset j when end of key is reached
            }
        }
        string result = sb.ToString();
        return result;
    }
}
