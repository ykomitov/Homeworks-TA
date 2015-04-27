/*	Write a program that finds the maximal increasing sequence in an array.

_Example:_

|          input          | result  |
|-------------------------|---------|
| 3, **2, 3, 4**, 2, 2, 4 | 2, 3, 4 |*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxIncreasingSequence
{
    static void Main()
    {
        string input = "3, 2, 3, 4, 2, 2, 4"; //2, 3, 4

        //<------- Other tests for your convinience ;) ------->

        //string input = "1, 2, 3, 5, 5, 5, 2, 2, 2, 2"; //1, 2, 3, 5
        //string input = "5, 5, 5, 6, 5, 4, 2, 2, 2, 2"; //5, 6
        //string input = "0, 5, 0, 6, 5, 5, 2, 2, 2, 1"; //0, 5
        //string input = "1, 2, 6, 5, 5, 2, 0, 1, 2, 3"; //0, 1, 2, 3
        //string input = "10, 9, 8, 7, 6, 5, 2, 2, 2, 2"; //No sequence of repeating elements

        //Remove all spaces in the string & then split it using the commas into an int array
        int[] inputArray = input.Replace(" ", string.Empty).Split(',').Select(n => Int32.Parse(n)).ToArray();

        int indexEnd = 0;
        int lenght = 0;
        int increasingSequenceLenght = 0;


        for (int i = 0, j = 1; i < inputArray.Length - 1; i++)
        {
            if (inputArray[i] < inputArray[j])
            {
                lenght++; //Get the lenght of the increasing sequence
                j++; //Get the index of position [i+1]

                if (lenght > increasingSequenceLenght) //Check if this sequence is longer than all previous sequences
                {
                    increasingSequenceLenght = lenght;
                    indexEnd = j - 1;
                }
            }
            else
            {
                j++;
                lenght = 0; //Clear the lenght to test another sequence
            }
        }

        //In case there's no increasing sequence
        if (lenght == 0)
        {
            Console.WriteLine("No sequence of repeating elements");
        }
        else
        {
            //Print the maximal increasing sequence
            for (int i = indexEnd - increasingSequenceLenght; i <= indexEnd; i++)
            {
                if (i < indexEnd)
                {
                    Console.Write(inputArray[i] + ", ");
                }
                if (i == indexEnd)
                {
                    Console.WriteLine(inputArray[i]);
                }
            }
        }
    }
}
