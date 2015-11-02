/*Write a program that removes from given sequence all numbers that occur odd number of times.

    Example:
        {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
*/

namespace _06.RemoveNumbersOccuringOddTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RemoveOddOccuringNumbers
    {
        public static void Main()
        {
            var inputList = new List<decimal> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var listWithoutNumbersOccuringOddTimes = RemoveNumbersOccuringOddTimes(inputList);

            Console.WriteLine(string.Join(", ", listWithoutNumbersOccuringOddTimes));
        }

        // The method uses generics, so it can work with all value types
        public static List<T> RemoveNumbersOccuringOddTimes<T>(IEnumerable<T> inputList)
        {
            List<T> result = new List<T>();
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
                if (occurances[item] % 2 == 0)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
