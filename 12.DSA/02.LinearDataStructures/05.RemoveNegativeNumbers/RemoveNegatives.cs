/*Write a program that removes from given sequence all negative numbers.
*/

namespace _05.RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public class RemoveNegatives
    {
        public static void Main()
        {
            ////var inputList = new List<int> { 1, -11, 1, 2, 2, 2, 0, 0, -9190, 0 };
            ////var inputList = new List<decimal> { 1, 11, 1, 2, 2, 2, -0.01m, 0, 9190, -0.01m };
            var inputList = new List<double> { 1, -11, -1, 2, -0.01, 3, -0.01 };

            var listWithoutNegatives = RemoveNegativeNumbers(inputList);

            Console.WriteLine(string.Join(", ", listWithoutNegatives));
        }

        // The method uses generics, so it can work with all value types
        public static List<T> RemoveNegativeNumbers<T>(IEnumerable<T> inputList) where T : IComparable
        {
            List<T> result = new List<T>();
            Type typeParameterType = typeof(T);

            foreach (var item in inputList)
            {
                // Initializing the zero, used in the CompareTo in the same type as the input list
                var zero = default(T);

                if (item.CompareTo(zero) >= 0)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
