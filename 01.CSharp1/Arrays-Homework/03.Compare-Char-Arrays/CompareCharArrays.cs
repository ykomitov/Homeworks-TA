//	Write a program that compares two `char` arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompareCharArrays
{
    static void Main()
    {
        //Initialize the two arrays
        char[] array1 = { 'А', 'н', 'а', 'н', 'а', 'с' };
        char[] array2 = { 'А', 'н', 'а' };

        //Get the length of both arrays
        int arrayOneL = array1.Length;
        int arrayTwoL = array2.Length;

        string isFirst = "";

        for (int i = 0; i < Math.Min(arrayOneL, arrayTwoL); i++)
        {
            if (array1[i] < array2[i])
            {
                isFirst = "array1";
                break;
            }
            else if (array1[i] > array2[i])
            {
                isFirst = "array2";
                break;
            }
        }
        if (isFirst == "")
        {
            if (arrayOneL < arrayTwoL)
            {
                isFirst = "array1";
            }
            else if (arrayOneL > arrayTwoL)
            {
                isFirst = "array2";
            }
            else if (arrayOneL == arrayTwoL)
            {
                Console.WriteLine("Two arrays are equal!");
            }
        }
        if (isFirst != "")
        {
            Console.WriteLine("The first array lexicographically is {0}", isFirst);
        }
    }
}
