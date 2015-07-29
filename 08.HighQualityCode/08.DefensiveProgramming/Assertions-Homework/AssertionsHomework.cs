namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public class AssertionsHomework
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SelectionSortAlgorithm.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SelectionSortAlgorithm.SelectionSort(new int[0]); // Test sorting empty array
            SelectionSortAlgorithm.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(BinarySearchAlgorithm.BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearchAlgorithm.BinarySearch(arr, 0));
            Console.WriteLine(BinarySearchAlgorithm.BinarySearch(arr, 17));
            Console.WriteLine(BinarySearchAlgorithm.BinarySearch(arr, 10));
            Console.WriteLine(BinarySearchAlgorithm.BinarySearch(arr, 1000));
        }
    }
}