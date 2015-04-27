//Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Please input a string: ");
        string input = Console.ReadLine();


        //1. Reverse a string using a for loop

        StringBuilder sb = new StringBuilder();

        //Reverse the input string with a for loop
        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }

        //Build the reversed string
        string reversedV1 = sb.ToString();
        Console.WriteLine(reversedV1);

        //2. Reverse a string using a char array

        char[] inputChars = input.ToCharArray();
        Array.Reverse(inputChars);
        string reversedV2 = String.Join("", inputChars);
        Console.WriteLine(reversedV2);

        //3. Reverse a string using LINQ
        string reversedV3 = new string(input.Reverse().ToArray());
        Console.WriteLine(reversedV3);
    }
}
