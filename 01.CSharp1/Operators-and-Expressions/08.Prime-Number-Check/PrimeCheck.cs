using System;

//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

class PrimeCheck
{
    static void Main()
    {
        Console.Write("Please intup an integer: ");
        int input = int.Parse(Console.ReadLine());
        bool PrimeCheck = true;

        for (int i = input - 1; i > 1; i--)
        {
            if (input % i == 0)
            {
                PrimeCheck = false;
                break;
            }
        }
        Console.WriteLine("Is prime: " + PrimeCheck);
    }
}
