//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.

using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Please enter some text: ");
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            string output = String.Format("\\u{0:X4}", (int)input[i]);
            Console.Write(output);
        }
        Console.WriteLine();
    }
}