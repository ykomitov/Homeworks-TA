/*Write a program that reads from the console a sequence of positive integer numbers.

    The sequence ends when empty line is entered.
    Calculate and print the sum and average of the elements of the sequence.
    Keep the sequence in List<int>.
*/

namespace _01.UseList
{
    using System;
    using System.Collections.Generic;

    public class NumbersInList
    {
        public static void Main()
        {
            var inputNumbers = new List<uint>();
            uint sum = 0;
            var continueLoop = true;

            while (continueLoop)
            {
                Console.Write("Please input a positive number: ");
                var input = Console.ReadLine();
                uint currentNumber;
                continueLoop = uint.TryParse(input, out currentNumber);

                if (continueLoop)
                {
                    sum += currentNumber;
                    inputNumbers.Add(currentNumber);
                }
            }

            Console.WriteLine("The sum of the input numbers is: {0}", sum);

            if (inputNumbers.Count > 0)
            {
                Console.WriteLine("The average of the input numbers is {0}", (double)sum / inputNumbers.Count);
            }
        }
    }
}
