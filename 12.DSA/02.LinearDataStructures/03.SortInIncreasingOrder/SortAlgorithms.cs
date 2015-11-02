namespace _03.SortInIncreasingOrder
{
    using System.Collections.Generic;

    public static class SortAlgorithms
    {
        /// <summary>
        /// This method contains my implementation of the Merge Sort algorithm using lists, as described in Wikipedia's article: https://en.wikipedia.org/wiki/Merge_sort. This core method splits the input lists in half recursively.
        /// </summary>
        /// <param name="input">List of integers.</param>
        /// <returns>List of integers, sorted in ascending order.</returns>
        public static List<int> MergeSort(List<int> input)
        {
            if (input.Count <= 1)
            {
                return input;
            }

            var left = new List<int>();
            var right = new List<int>();
            var middle = input.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(input[i]);
            }

            for (int i = middle; i < input.Count; i++)
            {
                right.Add(input[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        /// <summary>
        /// Helper method for the Merge Sort algorithm. Merges the left and right lists and orders the items in them in increasing order.
        /// </summary>
        /// <param name="left">The left input list.</param>
        /// <param name="right">The right input list.</param>
        /// <returns>The two lists are merged and all their members are sorted in ascending order.</returns>
        private static List<int> Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while (left.Count != 0 && right.Count != 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result;
        }
    }
}
