namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            this.CopyArray(collection, this.MergeSort(collection)); 
        }

        private IList<T> MergeSort(IList<T> input)
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

            return this.Merge(this.MergeSort(left), this.MergeSort(right));
        }

        private IList<T> Merge(IList<T> left, IList<T> right)
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

        private void CopyArray(IList<T> original, IList<T> sorted)
        {
            bool arrayHaveEqualLength = original.Count == sorted.Count;
            Debug.Assert(arrayHaveEqualLength, "The two arrays must always have the same length!");

            for (int i = 0; i < original.Count; i++)
            {
                for (int j = 0; j < sorted.Count; j++)
                {
                    original[i] = sorted[i];
                }
            }
        }
    }
}
