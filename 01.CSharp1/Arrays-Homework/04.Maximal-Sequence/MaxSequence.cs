/*	Write a program that finds the **maximal sequence** of equal elements in an array.

_Example:_

|              input              | result  |
|---------------------------------|---------|
| 2, 1, 1, 2, 3, 3, **2, 2, 2**, 1 | 2, 2, 2 |*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxSequence
{
    static void Main()
    {
        string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1"; //2, 2, 2

        //<------- Other tests for your convinience ;) ------->

        //string input = "0, 5, 5, 5, 5, 5, 2, 2, 2, 2"; //5, 5, 5, 5, 5
        //string input = "5, 5, 5, 6, 5, 4, 2, 2, 2, 2"; //2, 2, 2, 2
        //string input = "0, 5, 0, 5, 5, 5, 2, 2, 2, 1"; //5, 5, 5
        //string input = "6, 6, 6, 5, 5, 2, 2, 1, 2, 2"; //6, 6, 6
        //string input = "w, t, f, w, t, f, w, t, f, f"; //f, f
        //string input = "|, |, |, |, |, |, |, |, |, |"; //|, |, |, |, |, |, |, |, |, |
        //string input = "|, 4, |, 8, |, 9, |, -, |, r"; //No sequence of repeating elements


        //Remove all spaces in the string & then split it using the commas
        string[] inputArray = input.Replace(" ", string.Empty).Split(','); 

        string value = "";
        int count = 0;
        int maxSequenceLenght = 0;

        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            for (int j = i + 1; j < inputArray.Length; j++)
            {
                if (inputArray[i] == inputArray[j])
                {
                    count++; //Count the repetitions
                }
                else
                {
                    break; //No sequence, move to the next element of the array
                }

                if (count > maxSequenceLenght) //Check if the current sequence is longer than all previously found
                {
                    maxSequenceLenght = count;
                    value = (string)inputArray[i]; //Record the max repeating value
                }
            }
            count = 0; //Restart the counter
        }

        //Print the max sequence
        for (int i = 1; i <= maxSequenceLenght; i++)
        {
            Console.Write(value + ", ");

            if (i == maxSequenceLenght)
            {
                Console.WriteLine(value);
            }
        }

        //In case there's no repeating sequence
        if (value == "")
        {
            Console.WriteLine("No sequence of repeating elements");
        }
    }
}