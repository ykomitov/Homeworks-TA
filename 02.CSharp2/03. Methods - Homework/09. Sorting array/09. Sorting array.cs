/*Write a method that return the maximal element in a portion of array of integers starting at given index. 
 * Using it write another method that sorts an array in ascending / descending order.*/

using System;
using AppearanceCount;

class SortingArray
{
    static void Main()
    {
        int[] input = { 536, 921, 906, 115, 0, 292, 509, 742, 220, 761, 437, 999 };

        //Print the initial array
        Console.Write("  Original: ");
        AppearanceCount.AppearanceCount.ArrayPrint(input);

        //Sort descending & print
        SortArrayDescending(input);
        Console.Write(" Ascending: ");
        AppearanceCount.AppearanceCount.ArrayPrint(input);

        //Sort ascending & print
        SortArrayAscending(input);
        Console.Write("Descending: ");
        AppearanceCount.AppearanceCount.ArrayPrint(input);
    }

    static void SortArrayDescending(int[] input)
    {
        //Sort the array in descending order
        int temp = int.MinValue;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] < input[MaxElement(input, i)])
            {
                temp = input[MaxElement(input, i)];
                input[MaxElement(input, i)] = input[i];
                input[i] = temp;
            }
        }
    }

    static void SortArrayAscending(int[] input)
    {
        SortArrayDescending(input);
        Array.Reverse(input);
    }

    static int MaxElement(int[] inputArray, int indexStart)
    {
        //Find the index of the max element in the array
        int maxElement = int.MinValue;
        int indexMax = 0;

        for (int i = indexStart; i < inputArray.Length; i++)
        {
            if (inputArray[i] > maxElement)
            {
                maxElement = inputArray[i];
                indexMax = i;
            }
        }
        return indexMax;
    }
}
