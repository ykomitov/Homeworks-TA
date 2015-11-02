/*The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.

    Write a program to find the majorant of given array (if exists).
    Example:
        {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
*/

namespace _08.FindMajorant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindMajorant
    {
        public static void Main()
        {
            ////int[] input = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2, 666 }; // => none
            ////int[] input = new int[] { 2, 3, 3, 2, 3, 4, 3, 3 };     // => 3
            int[] input = new int[] { 4, 4, 4, 4, 3, 4, 1, 1, 1 };  // => 4, loop should end after the last 4
            var majorant = Majorant(input);
            Console.WriteLine("Majorant: {0}", majorant == null ? "none" : majorant.ToString());
        }

        public static int? Majorant(IEnumerable<int> inputList)
        {
            int minCount = (inputList.Count() / 2) + 1;
            Dictionary<int, int> occurances = new Dictionary<int, int>();
            int? majorant = null;

            // Count occurances of each unique key in the sequence by looping through the sequence only once
            foreach (var item in inputList)
            {
                if (occurances.ContainsKey(item))
                {
                    occurances[item]++;
                }
                else
                {
                    occurances.Add(item, 1);
                }

                if (occurances[item] >= minCount)
                {
                    majorant = item;

                    // There can be only one majorant, so after it has been found we can stop itterating through the remaining elements
                    break;
                }
            }

            return majorant;
        }
    }
}
