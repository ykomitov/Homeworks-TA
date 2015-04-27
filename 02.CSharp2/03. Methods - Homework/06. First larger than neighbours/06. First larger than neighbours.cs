/*  Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
 * Use the method from the previous exercise.*/

using System;
using AppearanceCount;
using LargerThanNeighbours;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] input = { 1, 2, 3, 4 }; //No element is larger than its neighbours!

        //Some other arrays for testing:

        //int[] input = { 536, 921, 906, 115, 680, 292, 509, 742, 220, 761, 437, 368 }; //Array[1] = 921
        //int[] input = { 138, 8, 233, 233, 233, 233, 60, 233, 233, 416, 490, 73 }; //Array[1] = 490

        //Find the index of the first element in array that is larger than its neighbours
        for (int i = 0; i < input.Length; i++)
        {
            if (LargerThanNeighbours.LargerThanNeighbours.CheckNeighbours(input, i))
            {

                Console.Clear(); //Clear the console

                //Print the input array using the method from AppearanceCount (Problem 4)
                AppearanceCount.AppearanceCount.ArrayPrint(input);

                Console.WriteLine("The first element larger than its neighbours is:\r\nArray[{0}] = {1}", i, input[i]);
                break;
            }
            else
            {
                Console.Clear(); //Clear the console

                //Print the input array using the method from AppearanceCount (Problem 4)
                AppearanceCount.AppearanceCount.ArrayPrint(input);

                Console.WriteLine("-1\r\nNo element is larger than its neighbours!");
            }
        }
    }
}
