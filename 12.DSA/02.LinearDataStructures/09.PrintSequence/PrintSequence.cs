/*We are given the following sequence:

    S1 = N;
    S2 = S1 + 1;
    S3 = 2*S1 + 1;
    S4 = S1 + 2;
    S5 = S2 + 1;
    S6 = 2*S2 + 1;
    S7 = S2 + 2;
    ...
    Using the Queue<T> class write a program to print its first 50 members for given N.
    Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
*/

namespace _09.PrintSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PrintSequence
    {
        public static void Main()
        {
            var startingNumber = 2;
            var members = 50;

            PrintNumbersInSequence(startingNumber, members);
        }

        public static void PrintNumbersInSequence<T>(T startingNumber, int lengthOfSequence) where T : struct
        {
            var result = new Queue<T>();
            result.Enqueue(startingNumber);

            for (int i = 0; i < lengthOfSequence; i++)
            {
                dynamic root = result.First();

                if (i <= lengthOfSequence / 3)
                {
                    dynamic x = root + 1;
                    dynamic y = (2 * root) + 1;
                    dynamic z = root + 2;

                    result.Enqueue(x);
                    result.Enqueue(y);
                    result.Enqueue(z);
                }

                if (i < lengthOfSequence - 1)
                {
                    Console.Write("{0}, ", result.Dequeue());
                }
                else
                {
                    Console.WriteLine("{0}", result.Dequeue());
                }
            }
        }
    }
}
