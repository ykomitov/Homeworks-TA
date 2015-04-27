using System;

//The gravitational field of the Moon is approximately `17%` of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

class MoonGravity
{
    static void Main()
    {
        Console.Write("Please intup a weigth in kg: ");
        double weigth = double.Parse(Console.ReadLine());
        Console.WriteLine("The man's weight on the moon will be {0:#.##} kg.", (weigth * 0.17));
    }
}

