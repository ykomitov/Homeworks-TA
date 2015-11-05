/*Write a program that counts in a given array of double values the number of occurrences of each value. Use Dictionary<TKey,TValue>.

    Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
    -2.5 -> 2 times
    3 -> 4 times
    4 -> 3 times
*/

namespace _01.CountOccurances
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            double[] input = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5, 0.011 };

            CountOccurances(input);
        }

        public static void CountOccurances(double[] input)
        {
            var occurances = new Dictionary<double, int>();

            // Count occurances of each unique key in the sequence by looping through the sequence only once
            foreach (var number in input)
            {
                if (occurances.ContainsKey(number))
                {
                    occurances[number]++;
                }
                else
                {
                    occurances[number] = 1;
                }
            }

            foreach (var num in occurances)
            {
                var text = num.Value == 1 ? "time" : "times";

                Console.WriteLine("{0} : {1} {2}", num.Key, num.Value, text);
            }
        }
    }
}
