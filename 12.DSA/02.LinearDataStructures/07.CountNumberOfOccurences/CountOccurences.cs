/*Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.

    Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
        2 → 2 times
        3 → 4 times
        4 → 3 times
*/

namespace _07.CountNumberOfOccurences
{
    using System;
    using System.Collections.Generic;

    public class CountOccurences
    {
        public static void Main()
        {
            int[] input = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2, 666 };

            CountOccurances(input);
        }

        // The method uses generics, so it can work with all value types
        public static void CountOccurances(int[] input)
        {
            int[] occurances = new int[1001];

            // Count occurances of each unique key in the sequence by looping through the sequence only once
            foreach (var number in input)
            {
                occurances[number]++;
            }

            for (int i = 0; i < occurances.Length; i++)
            {
                if (occurances[i] != 0)
                {
                    var text = occurances[i] == 1 ? "time" : "times";

                    Console.WriteLine("{0} : {1} {2}", i, occurances[i], text);
                }
            }
        }
    }
}
