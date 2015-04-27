using System;

/*	Write a program that reads an integer number `n` from the console and prints all the numbers in the interval `[1..n]`, each on a single line.

_Note: You may need to use a for-loop._

_Examples:_

| input | output |
|-------|--------|
| 3     | 1      |
|       | 2      |
|       | 3      |
| 5     | 1      |
|       | 2      |
|       | 3      |
|       | 4      |
|       | 5      |
| 1     | 1      |*/

class PrintNumsFrom1ToN
{
    static void Main()
    {
        Console.Write("Please enter an integer n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
