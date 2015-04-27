/*  Write a program, that reads from the console an array of N integers and an integer K
 *  sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K*/

using System;

class BinarySearch
{
    static void Main()
    {
        ////Read the array size & values from the console -------------------------------------> DISABLED
        //Console.Write("Please enter N (the number of integers in the array): ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("Please enter integer K: ");
        //int k = int.Parse(Console.ReadLine());

        //int[] vectorArray = new int[n];

        ////Fill the array with numbers from the console
        //for (int i = 0; i < vectorArray.Length; i++)
        //{
        //    Console.Write("Please enter integer for index {{{0}}} = ", i);
        //    vectorArray[i] = int.Parse(Console.ReadLine());
        //}

        /*>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> sample input to check if the code runs as expected*/

        int k = 7;
        int[] vectorArray = { 2, 3, 4, -5, 6 }; //Expected outcome: 6

        //More sample combinations follow below

        //int k = 6;
        //int[] vectorArray = { 2, 3, 4, -5, 6 }; //Expected outcome: 6

        //int k = -5;
        //int[] vectorArray = { 2, 3, 4, -5, 6 }; //Expected outcome: -5

        //int k = 5;
        //int[] vectorArray = { 2, 3, 4, -5, 6 }; //Expected outcome: 4

        //int k = -55;
        //int[] vectorArray = { 2, 3, 4, -5, 6 }; //Expected outcome: All elements of the array are larger than K

        //Print the array before sorting
        Console.WriteLine("Unsorted array:");
        ArrayPrint(vectorArray);

        //Sort the array & print it
        Console.WriteLine();
        Console.WriteLine("Sorted array:");
        Array.Sort(vectorArray);
        ArrayPrint(vectorArray);
        Console.WriteLine();

        //If K is found in the array => find the largest number <= K;
        if (Array.BinarySearch(vectorArray, k) > 0) //K is not the first element => get K-1
        {
            Console.WriteLine("K = {0}", k);
            Console.WriteLine("Largest number in the array which is <= K is {0}", vectorArray[Array.BinarySearch(vectorArray, k)]);
        }
        else if (Array.BinarySearch(vectorArray, k) == 0) //K is the first element of the array => get K
        {
            Console.WriteLine("K = {0}", k);
            Console.WriteLine("Largest number in the array which is <= K is {0}", vectorArray[Array.BinarySearch(vectorArray, k)]);
        }

        //Cases where K is not found in the array
        else if (Array.BinarySearch(vectorArray, k) < 0)
        {
            //If there are no elements, larger than K in the array we need the last element from the array
            if (~(Array.BinarySearch(vectorArray, k)) == vectorArray.Length)
            {
                Console.WriteLine("K = {0}", k);
                Console.WriteLine("Largest number in the array which is <= K is {0}", vectorArray[(vectorArray.Length - 1)]);
            }

            //If there are elements larger than K => we get the index of the first larger element, so we need the element before it
            else if (~(Array.BinarySearch(vectorArray, k)) != vectorArray.Length)
            {
                if (~(Array.BinarySearch(vectorArray, k)) == 0)
                {
                    Console.WriteLine("All elements of the array are larger than K = {0}", k);
                }
                else
                {
                    Console.WriteLine("K = {0}", k);
                    Console.WriteLine("Largest number in the array which is <= K is {0}", vectorArray[~(Array.BinarySearch(vectorArray, k)) - 1]);
                }
            }
        }
        Console.WriteLine();
    }

    static void ArrayPrint(int[] input)
    {
        string printArray = string.Join(", ", input);
        Console.WriteLine(printArray);
    }
}

