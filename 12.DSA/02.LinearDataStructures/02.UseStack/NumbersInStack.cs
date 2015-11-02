/*Write a program that reads N integers from the console and reverses them using a stack.

    Use the Stack<int> class.

*/

namespace _02.UseStack
{
    using System;
    using System.Collections.Generic;

    public class NumbersInStack
    {
        public static void Main()
        {
            var inputNumbers = new Stack<int>();
            var continueLoop = true;

            while (continueLoop)
            {
                Console.Write("Please input a positive number: ");
                var input = Console.ReadLine();
                int currentNumber;
                continueLoop = int.TryParse(input, out currentNumber);

                if (continueLoop)
                {
                    inputNumbers.Push(currentNumber);
                }
            }

            Console.WriteLine(string.Join(", ", inputNumbers));
        }
    }
}
