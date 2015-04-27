//	Write a program that reads two `integer` arrays from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class CompareArrays
{
    static void Main()
    {

        //Initilize the two arrays
        int arraysLength = 10;
        int[] array1 = new int[arraysLength];
        int[] array2 = new int[arraysLength];

        //Read the input from file input.txt
        StreamReader reader = new StreamReader("..\\..\\input.txt");
        Console.SetIn(reader);

        //Read array 1 from the console
        for (int i = 0; i < arraysLength; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        //Read array 2 from the console
        for (int i = 0; i < arraysLength; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }

        //Compare array 1 to array 2
        for (int i = 0; i < arraysLength; i++)
        {
            if (array1[i] == array2[i])
            {
                Console.WriteLine("Array1[{0}] = Array2[{0}] => {1} vs. {2}", i, array1[i], array2[i]);
            }
            else if (array1[i] > array2[i])
            {
                Console.WriteLine("Array1[{0}] > Array2[{0}] => {1} vs. {2}", i, array1[i], array2[i]);
            }
            else if (array1[i] < array2[i])
            {
                Console.WriteLine("Array1[{0}] < Array2[{0}] => {1} vs. {2}", i, array1[i], array2[i]);
            }
        }
    }
}
