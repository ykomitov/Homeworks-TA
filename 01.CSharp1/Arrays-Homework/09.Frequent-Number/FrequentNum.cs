/*	Write a program that finds the most frequent number in an array.

_Example:_

|                  input                |    result   |
|---------------------------------------|-------------|
| **4**, 1, 1, **4**, 2, 3, **4**, **4**, 1, 2, **4**, 9, 3 | 4 (5 times) |*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FrequentNum
{
    static void Main()
    {
        string input = "4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3"; //4 (5 times)
        int freqNum = int.MinValue;
        int maxCount = int.MinValue;
        int tempCount = 0;

        //<------- Other tests for your convinience ;) ------->

        //string input = "1, -2, 3, 5, 5, 5, -2, -2, -2, -2"; // -2 (5 times)
        //string input = "5, 5, 5, -6, 5, -4, 2, 2, -2, 2"; //5 (4 times)
        //string input = "0, -5, 0, 6, -5, 5, -2, -2, 2, 0"; //0 (3 times)
        //string input = "1, -2, -6, -5, 5, 2, 0, -1, 22, -3"; //No repeating number found

        //Convert string to integer array
        int[] intArray = Array.ConvertAll(input.Split(','), Convert.ToInt32);

        //Find the most frequent number in an array by counting how many times each number is present
        for (int i = 0; i < intArray.Length - 1; i++)
        {
            tempCount = 0; //Clear the temporary counter

            for (int j = i + 1; j < intArray.Length; j++)
            {
                if (intArray[i] == intArray[j])
                {
                    tempCount++;
                }
            }

            //Save the number & its count in case it is higher than what was previously found
            if (tempCount > maxCount)
            {
                maxCount = tempCount;
                freqNum = intArray[i];
            }
        }

        //Print result on the console
        if (maxCount == 0)
        {
            Console.WriteLine("No repeating number found"); //Case where no repeating number is found
        }

        else
        {
            Console.WriteLine("{0} ({1} times)", freqNum, (maxCount + 1));
        }
    }
}
