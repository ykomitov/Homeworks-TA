/*	Write a program that finds the sequence of maximal sum in given array.

_Example:_

|                 input               |    result   |
|-------------------------------------|-------------|
| 2, 3, -6, -1, **2, -1, 6, 4**, -8, 8 | 2, -1, 6, 4 |

*	_Can you do it with only one loop (with single scan through the elements of the array)?_*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSum
{
    static void Main()
    {
        string input = "2, 3, -6, -1, 2, -1, 6, 4, -8, 8"; // 2, -1, 6, 4
        int maxSum = int.MinValue;
        int maxTemp = 0;
        int indexStart = 0;
        int indexEnd = 0;

        //<------- Other tests for your convinience ;) ------->

        //string input = "1, -2, 3, 5, 5, 5, -2, -2, -2, -2"; // 3, 5, 5, 5
        //string input = "5, 5, 5, -6, -5, -4, 2, 2, -2, 2"; //5, 5, 5
        //string input = "0, -5, 0, 6, -5, 5, -2, -2, 2, 1"; //0, 6
        //string input = "1, -2, -6, -5, 5, 2, 0, -1, 2, -3"; //5, 2, 0, -1, 2

        //Convert string to integer array
        int[] intArray = Array.ConvertAll(input.Split(','), Convert.ToInt32);

        //Go through all possible combinations in the array
        for (int i = 0; i < intArray.Length - 1; i++)
        {
            maxTemp = intArray[i];
            for (int j = i + 1; j < intArray.Length; j++)
            {
                maxTemp += intArray[j];

                if (maxTemp > maxSum)
                {
                    maxSum = maxTemp;
                    indexStart = i; //find the starting index of the subset with max sum
                    indexEnd = j; //find the ending index of the subset with max sum
                }
            }
        }

        //Print the sequence with maximal sum
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
}