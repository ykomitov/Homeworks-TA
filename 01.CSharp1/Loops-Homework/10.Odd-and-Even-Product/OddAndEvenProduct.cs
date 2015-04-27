using System;
using System.Linq;

/*	You are given `n` integers (given in a single line, separated by a space).
*	Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
*	Elements are counted from `1` to `n`, so the first element is odd, the second is even, etc.

_Examples:_

| numbers           | result |
|-------------------|--------|
| 2 1 1 6 3         | yes    |
| product = 6       |        |
|                   |        |
| 3 10 4 6 5 1      | yes    |
| product = 60      |        |
|                   |        |
| 4 3 2 5 2         | no     |
| odd_product = 16  |        |
| even_product = 15 |        |*/

class OddAndEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();

        //split the string and put all values in an array
        int[] array = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

        //Create variables for even and odd products
        decimal productEven = 1;
        decimal productOdd = 1;

        for (int i = 0; i < array.Length; i += 2)
        {
            productOdd *= array[i];
        }

        for (int j = 1; j < array.Length; j+=2)
        {
            productEven *= array[j];
        }
        Console.WriteLine(productOdd ==  productEven ? "yes" : "no");
    }
}
