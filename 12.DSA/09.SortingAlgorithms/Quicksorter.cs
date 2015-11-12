namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            this.QuickSort(collection, 0, collection.Count - 1);
        }

        private void QuickSort(IList<T> arr, int from, int to)
        {
            if (to - from <= 1)
            {
                return;
            }

            T pivot = arr[from];
            int pos = from;

            for (int i = from + 1; i <= to; i++)
            {
                if (arr[i].CompareTo(pivot) < 0)
                {
                    pos++;
                    HelperMethods.Swap(arr, i, pos);
                }
            }

            HelperMethods.Swap(arr, pos, from);

            this.QuickSort(arr, from, pos - 1);
            this.QuickSort(arr, pos + 1, to);
        }
    }
}
