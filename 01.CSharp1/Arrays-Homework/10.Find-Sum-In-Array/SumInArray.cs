/*	Write a program that finds in given array of integers a sequence of given sum `S` (if present).

_Example:_

|        array            |  S |  result |
|-------------------------|----|---------|
| 4, 3, 1, **4, 2, 5**, 8 | 11 | 4, 2, 5 |*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumInArray
{
    static void Main()
    {
        int s = 11;
        string input = "4, 3, 1, 4, 2, 5, 8"; // s = 11; sequence: 4, 2, 5
        int sumTemp = 0;
        int indexStart = 0;
        int indexEnd = 0;

        //<------- Other tests for your convinience ;) ------->

        //string input = "4, 3, 1, 4, 2, 5, 8"; // s = 9; sequence: 4, 2, 5
        //string input = "1, -2, 3, 5, 5, 5, -2, -2, -2, -2"; //s = -8; sequence: -2, -2, -2, -2
        //string input = "5, 5, 5, -6, -5, -4, 2, 2, -2, 2"; //s = -15; sequence: -6, -5, -4
        //string input = "0, -5, 0, 6, -5, 5, -2, -2, 2, 1"; //s = 4; sequence: 5, -2, -2, 2, 1
        //string input = "1, 2, 6, -5, -5, 2, 0, -11, -2, -3"; //s = 9; sequence:  1, 2, 6

        //Convert string to integer array
        int[] intArray = Array.ConvertAll(input.Split(','), Convert.ToInt32);

        //Go through all possible combinations in the array
        for (int i = 0; i < intArray.Length - 1; i++)
        {
            sumTemp = 0;
            sumTemp = intArray[i];

            for (int j = i + 1; j < intArray.Length; j++)
            {
                sumTemp += intArray[j];

                if (sumTemp == s)
                {
                    indexStart = i; //find the starting index of the subset with sum s
                    indexEnd = j; //find the ending index of the subset with sum s
                }
            }
        }

        //Print the sequence (if present)
         if (indexEnd != 0)
        {
            for (int i = indexStart; i <= indexEnd; i++)
            {
                if (i < indexEnd)
                {
                    Console.Write(intArray[i] + ", ");
                }
                else
                {
                    Console.WriteLine(intArray[i]);
                }
            }
        }

        else
        {
            Console.WriteLine("No sequence with the sum of {0}", s);
        }
    }
}
