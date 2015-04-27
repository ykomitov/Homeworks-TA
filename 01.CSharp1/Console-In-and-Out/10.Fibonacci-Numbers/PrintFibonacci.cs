using System;

/*	Write a program that reads a number `n` and prints on the console the first `n` members of the Fibonacci sequence (at a single line, separated by comma and space - `, `) : `0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, â€¦`.

_Note: You may need to learn how to use loops._

_Examples:_

|   n  |        comments        |
|:----:|------------------------|
| 1    | 0                      |
| 3    | 0 1 1                  |
| 10   | 0 1 1 2 3 5 8 13 21 34 |*/

class PrintFibonacci
{
    static void Main()
    {
        Console.Write("Please enter an integer n: ");
        uint n = uint.Parse(Console.ReadLine());
        int fi0 = 0;
        int fi1 = 1;

        if (n == 0)
        {
            Console.WriteLine(" ");
        }

        else if (n == 1)
        {
            Console.WriteLine(fi0);
        }

        else if (n == 2)
        {
            Console.WriteLine("{0}, {1}", fi0, fi1);
        }

        else
        {
            Console.Write("{0}, {1}, ", fi0, fi1);
            for (int i = 0; i < (n - 2); i++)
            {
                int temp = fi0;
                fi0 = fi1;
                fi1 = temp + fi0;

                Console.Write("{0}", fi1);

                if (i < (n - 3))
                {
                    Console.Write(", ");
                }
            }
        }
        Console.WriteLine("");
    }
}
