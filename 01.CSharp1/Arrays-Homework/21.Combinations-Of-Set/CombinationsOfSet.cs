/*	Write a program that reads two numbers `N` and `K` and generates all the combinations of `K` distinct elements from the set [`1..N`].

_Example:_

| N | K |                                                     result                                                 |
|:-:|:-:|:----------------------------------------------------------------------------------------------------------:|
| 5 | 2 | `{1, 2}`  `{1, 3}`   `{1, 4}`   `{1, 5}`   `{2, 3}`   `{2, 4}`   `{2, 5}`   `{3, 4}`   `{3, 5}`   `{4, 5}` |*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VariationsOfSet
{
    static void Main()
    {
        Console.Write("Please input N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please input K: ");
        int k = int.Parse(Console.ReadLine());

        //Initialize an array with Lenght = K
        int[] variations = new int[k];

        //Fill the array with 1's
        for (int i = 0; i <= k - 1; i++)
        {
            if (i < k - 1)
            {
                variations[i] = 1;
            }
            else
            {
                variations[i] = 0;
            }
        }

        bool printNext = true;
        Console.WriteLine();

        while (printNext)
        {
            //Generate combinations
            for (int i = k - 1; i >= 0; i--)
            {
                variations[i] += 1;

                //Reset digits to 1 if they reach n
                if (variations[i] > n)
                {
                    variations[i] = 1;
                }
                else
                {
                    break;
                }
            }

            //Check current combination validity & if valid print the array
            if (ValidCombination(variations))
            {
                string currentCombination = "{" + string.Join(", ", variations) + "}";
                Console.WriteLine(currentCombination);
            }

            //Check if printing needs to stop
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                if (variations[i] == n)
                {
                    count++;
                }
                if (count == k)
                {
                    printNext = false;
                }
            }
        }
    }

    static bool ValidCombination(int[] variations)
    {
        //Check if the current combination is made out of distinct elements
        for (int i = 0; i < variations.Length - 1; i++)
        {
            for (int j = i + 1; j < variations.Length; j++)
            {
                if (variations[i] >= variations[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
