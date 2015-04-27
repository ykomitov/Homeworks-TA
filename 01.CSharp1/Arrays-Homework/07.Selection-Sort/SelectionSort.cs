/*	**Sorting** an array means to arrange its elements in increasing order. Write a program to sort an array.
*	Use the [Selection sort](http://en.wikipedia.org/wiki/Selection_sort) algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.*/

using System;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        string input = "64, 25, 12, 11, 10, 234"; //10, 11, 12, 25, 64, 234
        int minTemp = int.MaxValue;
        int index = 0;

        //<------- Other tests for your convinience ;) ------->

        //string input = "1, 2, 3, 5, 5, 5, 2, 2, 2, 2"; //1, 2, 2, 2, 2, 2, 3, 5, 5, 5
        //string input = "5, 5, 5, 6, 5, 4, 2, 2, 2, 2"; //2, 2, 2, 2, 4, 5, 5, 5, 5, 6
        //string input = "0, 5, 0, 6, 5, 5, 2, 2, 2, 1"; //0, 0, 1, 2, 2, 2, 5, 5, 5, 6
        //string input = "1, 2, 6, 5, 5, 2, 0, 1, 2, 3"; //0, 1, 1, 2, 2, 2, 3, 5, 5, 6


        //Convert string to integer array & initialize empty sorted array
        int[] intArray = Array.ConvertAll(input.Split(','), Convert.ToInt32);
        int[] intArraySorted = new int[intArray.Length];

        //Sort the array using selection sort algorithm
        for (int i = 0; i < intArray.Length; i++)
        {
            minTemp = intArray.Min(); //find the min value in the array and copy it in var minTemp
            index = Array.IndexOf(intArray, intArray.Min()); //find the index of the min value
            intArray[index] = int.MaxValue; //replace the min value in the array with the biggest possible int value
            intArraySorted[i] = minTemp; //copy the min value in the sorted array
        }

        //Build new string from the sorted array & print initial input and sorted array on the console
        string sortedArr = string.Join(", ", intArraySorted);
        Console.WriteLine("Original: {0}", input);
        Console.WriteLine("Sorted:   {0}", sortedArr);
    }
}
