/*Write a recursive program for generating and printing all the combinations with duplicates of k elements from n-element set. Example:

    n=3, k=2 → (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
*/

namespace _02.CombinationsWithDuplicates
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int k = 2;
            var array = new int[k];

            GenerateCombinationsWithDuplicates(1, 3, array, 0);
        }

        private static void GenerateCombinationsWithDuplicates(int start, int end, int[] combination, int index)
        {
            if (index >= combination.Length)
            {
                Console.WriteLine(string.Join(", ", combination));
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    combination[index] = i;
                    GenerateCombinationsWithDuplicates(i, end, combination, index + 1);
                }
            }
        }
    }
}
