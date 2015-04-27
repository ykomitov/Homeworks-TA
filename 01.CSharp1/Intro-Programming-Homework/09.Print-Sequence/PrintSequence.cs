using System;

//Write a program that prints the first 10 members of the sequence: `2, -3, 4, -5, 6, -7, ...`

class PrintSequence
{
    static void Main(string[] args)
    {
        int a = 2;
        int b = -3;

        for (int i = 0; i < 5; i++)
        {
            Console.Write(a + " " + b + " ");
            a = a + 2;
            b = b - 2;
        }
    }
}

