//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortByStringLengh
{
    static void Main()
    {
        string[] input = { "aa", "ss", "a", "abc" };
        
        //Print original array before sorting
        ArrayPrint(input);

        //Sort the array
        Array.Sort(input, (x, y) => x.Length.CompareTo(y.Length));

        //Print the sorted array
        ArrayPrint(input);
    }

    static void ArrayPrint(string[] input)
    {
        string printArray = string.Join(", ", input);
        Console.WriteLine(printArray);
    }
}
