namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    internal class SelectionSortAlgorithm
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is not initialized!");
            Debug.Assert(arr.Length != 0, "Nothing to sort. Array is empty!");
            Debug.Assert(arr.Length != 1, "Nothing to sort. Array has only one element!");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is not initialized!");
            Debug.Assert(arr.Length != 0, "Nothing to sort. Array is empty!");
            Debug.Assert(arr.Length != 1, "Nothing to sort. Array has only one element!");
            Debug.Assert(startIndex >= 0, "Start index should be >= 0!");
            Debug.Assert(endIndex < arr.Length, "End index should be < array length!");
            Debug.Assert(startIndex < endIndex, "Start index should be < end index!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
