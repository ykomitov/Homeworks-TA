/*Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. Example:

    {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
*/

namespace _02.ExtractElementsFromString
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var inputList = new List<string> { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            var listWithoutNumbersOccuringOddTimes = ItemsOccuringOddTimes(inputList);

            Console.WriteLine(string.Join(", ", listWithoutNumbersOccuringOddTimes));
        }

        // The method uses generics, so it can work with all value types
        public static HashSet<T> ItemsOccuringOddTimes<T>(IEnumerable<T> inputList)
        {
            HashSet<T> result = new HashSet<T>();
            Dictionary<T, int> occurances = new Dictionary<T, int>();

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
            }

            foreach (var item in inputList)
            {
                if (!(occurances[item] % 2 == 0))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
