//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static void Main()
    {
        Random rnd = new Random();

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Random number {0:00}: {1}", i, rnd.Next(100, 200));
        }
    }
}

