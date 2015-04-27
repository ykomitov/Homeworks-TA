//Write a method that asks the user for his name and prints “Hello, <name>”. Write a program to test this method.

using System;

namespace SayHello
{
    public class SayHello
    {
        static void Main()
        {
            Console.Write("Please input your name: ");
            string input = Console.ReadLine();
            Console.WriteLine(ReturnHello(input));
        }

        public static string ReturnHello(string input)
        {
            return String.Format("Hello, {0}!", input);
        }
    }
}