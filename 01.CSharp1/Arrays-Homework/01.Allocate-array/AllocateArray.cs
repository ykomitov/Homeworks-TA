/*	Write a program that allocates array of `20` integers and initializes each element by its index multiplied by `5`.
*	Print the obtained array on the console.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] myFirstArray = new int[20];

        for (int i = 0; i < myFirstArray.Length; i++)
        {
            myFirstArray[i] = i * 5;
            Console.WriteLine("arr index {0} = {1}", i, myFirstArray[i]);
        }
        //string stringArray = string.Join(", ", myFirstArray);
        //Console.WriteLine(stringArray);
    }
}
