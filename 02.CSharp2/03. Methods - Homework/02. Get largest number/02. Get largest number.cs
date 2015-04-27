/*Write a method GetMax() with two parameters that returns the larger of two integers.
  Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax(). */

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Please input the first integer: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Please input the second integer: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Please input the third integer: ");
        int thirdNum = int.Parse(Console.ReadLine());

        Console.WriteLine("The largest number is {0}", GetMax(GetMax(firstNum, secondNum), thirdNum));

    }

    public static int GetMax(int parameter1, int parameter2)
    {
        int firstNumber = parameter1;
        int secondNumber = parameter2;

        if (firstNumber == secondNumber)
        {
            return firstNumber;
        }
        else if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}

