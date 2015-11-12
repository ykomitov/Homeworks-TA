namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            int minIndex;

            for (int j = 0; j < collection.Count - 1; j++)
            {
                minIndex = j;

                for (int i = j + 1; i < collection.Count; i++)
                {
                    if (collection[i].CompareTo(collection[minIndex]) < 0)
                    {
                        minIndex = i;
                    }
                }

                if (minIndex != j)
                {
                    HelperMethods.Swap(collection, minIndex, j);
                }
            }
        }
    }
}
