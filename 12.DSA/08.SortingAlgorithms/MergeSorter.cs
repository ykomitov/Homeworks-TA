namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            var sortedCollection = MergeSort(collection);

            for (int i = 0; i < collection.Count; i++)
            {
                for (int j = 0; j < sortedCollection.Count; j++)
                {
                    collection[i] = sortedCollection[i];
                }
            }
        }

        public static IList<T> MergeSort(IList<T> input)
        {
            if (input.Count <= 1)
            {
                return input;
            }

            var left = new List<T>();
            var right = new List<T>();
            var middle = input.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(input[i]);
            }

            for (int i = middle; i < input.Count; i++)
            {
                right.Add(input[i]);
            }


            return Merge(MergeSort(left), MergeSort(right));
        }

        private static IList<T> Merge(IList<T> left, IList<T> right)
        {
            var result = new List<T>();

            while (left.Count != 0 && right.Count != 0)
            {
                if (left[0].CompareTo(right[0]) <= 0)
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
