/*Write a recursive program for generating and printing all the combinations without duplicates of k elements from n-element set. Example: 

    n=4, k=2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
*/

namespace _03.CombinationsWithoutDuplicates
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int k = 2;
            int n = 4;
            var array = new int[k];

            GenerateCombinationsWithDuplicates(1, n, array, 0);
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
                    GenerateCombinationsWithDuplicates(i + 1, end, combination, index + 1); // recursive call is starting from the next number i + 1
                }
            }
        }
    }
}
