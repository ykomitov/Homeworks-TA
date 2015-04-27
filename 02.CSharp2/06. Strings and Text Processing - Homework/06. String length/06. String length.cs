/*•	Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *. Print the result string into the console.*/

using System;

class StringLength
{
    static void Main()
    {
        string input = "";

        //Read the string from the console
        do
        {
            Console.Write("Please enter a string of maximum 20 characters: ");
            input = Console.ReadLine();

            if (input.Length > 20)
            {
                Console.WriteLine("The string you entered is longer than 20 characters! Please try again!");
            }
        } while (input.Length > 20);

        if (input.Length < 20)
        {
            string fillString = new String('*', 20 - input.Length);
            input = input + fillString;
        }
        Console.WriteLine(input);
    }
}
