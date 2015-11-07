/*Write a recursive program for generating and printing all ordered k-element subsets from n-element set (variations Vkn).

    Example: n=3, k=2, set = {hi, a, b} → (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
*/

namespace _05.OrderedSubsets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        public static void Main()
        {
            int k = 2;
            var array = new string[k];
            var strings = new string[] { "hi", "a", "b" };

            GenerateSubsets(array, strings, 0);
        }

        private static void GenerateSubsets<T>(T[] subset, T[] original, int index)
        {
            if (index >= subset.Length)
            {
                Console.WriteLine(string.Join(", ", subset));
            }
            else
            {
                for (int i = 0; i < original.Length; i++)
                {
                    subset[index] = original[i];
                    GenerateSubsets(subset, original, index + 1);
                }
            }
        }
    }
}
