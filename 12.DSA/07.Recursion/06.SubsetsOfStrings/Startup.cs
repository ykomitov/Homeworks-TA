/*Write a program for generating and printing all subsets of k strings from given set of strings.

    Example: s = {test, rock, fun}, k=2 → (test rock), (test fun), (rock fun)
*/

namespace _06.SubsetsOfStrings
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int k = 2;
            var collectionOfSomething = new string[] { "test", "rock", "fun" };
            var output = new string[k];

            //var collectionOfSomething = new int[] { 1, 2, 3, 4 };
            //var output = new int[k];

            GenerateCombinationsWithDuplicates(0, collectionOfSomething, output, 0);

        }

        private static void GenerateCombinationsWithDuplicates<T>(int start, T[] input, T[] subset, int index)
        {
            if (index >= subset.Length)
            {
                Console.WriteLine(string.Join(", ", subset));
            }
            else
            {
                for (int i = start; i < input.Length; i++)
                {
                    subset[index] = input[i];
                    GenerateCombinationsWithDuplicates(i + 1, input, subset, index + 1);
                }
            }
        }
    }
}
