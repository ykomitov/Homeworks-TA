/*	Write a program that reads two integer numbers `N` and `K` and an array of `N` elements from the console.
*	Find in the array those `K` elements that have maximal sum.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class MaxKSum
{
    static void Main()
    {
        //Read the input from file input.txt - (the first two numbers are n & k, then currently there are 10 more integers for the array)
        StreamReader reader = new StreamReader("..\\..\\input.txt");
        Console.SetIn(reader);

        //Initialize n, k & the array
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] intArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            intArray[i] = int.Parse(Console.ReadLine());
        }

        //Sort the array in ascending order
        Array.Sort(intArray);

        //Reverse the array (it will then be sorted in descending order)
        Array.Reverse(intArray);

        //Print the k elements with maximal sum
        for (int i = 0; i < k; i++)
        {
            if (i < k - 1)
            {
                Console.Write(intArray[i] + ", ");
            }
            else 
            {
                Console.WriteLine(intArray[i]);
            }
        }

    }
}