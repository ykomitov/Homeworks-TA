namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    internal class BinarySearchAlgorithm
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr.Length != 0, "Nothing to sort. Array is empty!");
            Debug.Assert(arr.Length != 1, "Nothing to sort. Array has only one element!");
            Debug.Assert(value != null, "Search value is null.");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is not initialized!");
            Debug.Assert(value != null, "Search value is null.");
            Debug.Assert(arr.Length != 0, "Nothing to sort. Array is empty!");
            Debug.Assert(arr.Length != 1, "Nothing to sort. Array has only one element!");
            Debug.Assert(startIndex >= 0, "Start index should be >= 0!");
            Debug.Assert(endIndex < arr.Length, "End index should be < array length!");
            Debug.Assert(startIndex <= endIndex, "Start index should be <= end index!");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
