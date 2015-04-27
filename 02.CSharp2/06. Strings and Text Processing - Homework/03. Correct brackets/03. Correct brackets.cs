//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d)
//Example of incorrect expression: )(a+b))

using System;
using System.Linq;

class CorrectBrackets
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Please enter an expression, containing brackets to be checked: ");
            string input = Console.ReadLine();

            bool isCorrect = true;
            int test = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') test++;
                if (input[i] == ')') test--;
                if (test < 0) isCorrect = false;
            }
            if (test != 0) isCorrect = false;

            Console.WriteLine("Brackets are put correctly: {0}", isCorrect);
        }
    }
}

