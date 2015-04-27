/*	Write a program that sorts an array of strings using the [Quick sort](http://en.wikipedia.org/wiki/Quicksort) algorithm (find it in Wikipedia).*/

/*  1. Find a pivot element form the array.
    2. Rearrange the array so that all the elements smaller than pivot comes before and all the element greater than pivot comes after it. After this step the pivot element is in its final position.
    3. Recursively apply step 1 and 2 on the divided array.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuickSortStringArray
{
    static void Main()
    {
        Console.WriteLine("Please enter some words, separated by a space to be sorted:");
        string input = Console.ReadLine();

        //Split the string into a list of strings
        List<string> inputArray = new List<string>(input.Split(" .,!:-'()}{".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));

        //Print list values after sorting
        Console.WriteLine("Unsorted:");
        for (int i = 0; i < inputArray.Count; i++)
        {
            Console.WriteLine("i[{0}] = {1}", i, inputArray[i]);
        }
        Console.WriteLine();
        
        //Sort the list
        QuickSort(inputArray);

        //Print list values after sorting
        Console.WriteLine("Sorted:");
        for (int i = 0; i < inputArray.Count; i++)
        {
            Console.WriteLine("i[{0}] = {1}", i, inputArray[i]);
        }
    }


    static void QuickSort(List<string> unsortedList)
    {
        if (unsortedList.Count < 2)
        {
            return;
        }

        //Define pivot & two lists = left and right
        string pivot = unsortedList[unsortedList.Count / 2];
        List<string> leftList = new List<string>(); // to hold the elements smaller than the pivot
        List<string> rightList = new List<string>(); // to hold the elemnets bigger than the pivot

        //Divide the initial array
        for (int i = 0; i < unsortedList.Count; i++)
        {
            if (i == unsortedList.Count / 2)
            {
                continue;
            }
            else if (string.Compare(pivot, unsortedList[i]) > 0)
            {
                leftList.Add(unsortedList[i]);
            }
            else if (string.Compare(pivot, unsortedList[i]) < 0)
            {
                rightList.Add(unsortedList[i]);
            }
        }
        //Recursion
        QuickSort(leftList);
        QuickSort(rightList);

        unsortedList.Clear();

        //Merge the 2 lists & the pivot
        unsortedList.AddRange(leftList);
        unsortedList.Add(pivot);
        unsortedList.AddRange(rightList);
    }
}
