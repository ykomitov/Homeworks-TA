/*Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i]contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.*/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class NumberAsArray
{
    static void Main()
    {
        while (true) //Infinate loop to try out different combinations of a & b
        {
            Console.Write("Please enter positive integer a = ");
            uint a = uint.Parse(Console.ReadLine());
            Console.Write("Please enter positive integer b = ");
            uint b = uint.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
            AddPositiveNums(a, b);
        }
    }
    static void AddPositiveNums(uint a, uint b)
    {
        //Convert the numbers to two integer arrays
        int[] inputA = a.ToString().Select(o => Convert.ToInt32(o - 48)).Reverse().ToArray();
        int[] inputB = b.ToString().Select(o => Convert.ToInt32(o - 48)).Reverse().ToArray();

        //Copy the input arrays to new arrays with lenght = 10000
        int[] arrayA = new int[10000];
        int[] arrayB = new int[10000];
        Array.Copy(inputA, arrayA, inputA.Length);
        Array.Copy(inputB, arrayB, inputB.Length);

        //Create a list to hold the result
        List<int> result = new List<int>();

        //Perform the addition
        int remainder = 0;
        for (int i = 0; i < arrayB.Length; i++)
        {
            if (i == 0)
            {
                result.Add((arrayA[i] + arrayB[i]) % 10);
                remainder = (arrayA[i] + arrayB[i]) / 10;
            }
            else
            {
                result.Add(((arrayA[i] + arrayB[i]) + remainder) % 10);
                remainder = (arrayA[i] + arrayB[i] + remainder) / 10;
            }
        }

        //Replace all trailing zeros with int.MinValue
        for (int i = result.Count - 1; i >= 0; i--)
        {
            if (result[i] == 0)
            {
                result[i] = int.MinValue;
            }
            else
            {
                break;
            }
        }

        //Find the index of the first int.MinValue in the resulting list
        int firstIndexOfMin = result.FindIndex((o => o == int.MinValue));

        //Build the resulting string in reversed order
        StringBuilder sb = new StringBuilder();
        for (int i = firstIndexOfMin - 1; i >= 0; i--)
        {
            sb.Append(result[i]);
        }
        //Print the result on the console
        Console.WriteLine("Result from array addition: " + sb.ToString()+"\r\n");
    }
}

