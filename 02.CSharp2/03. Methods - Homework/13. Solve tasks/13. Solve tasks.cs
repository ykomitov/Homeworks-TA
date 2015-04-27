/*•	Write a program that can solve these tasks:
    o	Reverses the digits of a number
    o	Calculates the average of a sequence of integers
    o	Solves a linear equation a * x + b = 0
  •	Create appropriate methods.
  •	Provide a simple text-based menu for the user to choose which task to solve.
  •	Validate the input data:
    o	The decimal number should be non-negative
    o	The sequence should not be empty
    o	a should not be equal to 0*/

using System;
using ReverseDigits;
using IntegerCalculations;
using System.Collections.Generic;

class SolveTasks
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("> 1. Reverse the digits of a number                      <");
            Console.WriteLine("> 2. Calculate the average of a sequence of integers     <");
            Console.WriteLine("> 3. Solve a linear equasion in format \"a * x + b = 0\"   <");
            Console.WriteLine("==========================================================");

            Console.Write("\r\nPlease choose from the menu above: ");
            int menuChoice = int.Parse(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    decimal input = 0;
                    while (input <= 0)
                    {
                        Console.Write("\r\nPlease enter a positive decimal number: ");
                        input = decimal.Parse(Console.ReadLine());
                        if (input > 0)
                        {
                            input = ReverseDigits.ReverseAllDigits.ReverseDigits(input);
                            Console.WriteLine("\r\nReversed number: {0}\r\n", input);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\r\nNumber must be POSITIVE. Please try again.\r\n");
                        }
                    }
                    break;

                case 2:
                    Console.Write("\r\nPlease enter the number of integers to be processed: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    //Read & save the numbers in an array
                    int[] inputArr = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Please enter number {0}/{1}: ", i + 1, n);
                        inputArr[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("\r\nAverage = {0:0.00}\r\n", IntegerCalculations.IntegerCalculations.AverageArr(inputArr));
                    break;

                case 3:
                    Console.WriteLine("\r\nThis program will solve the equasion \"a * x + b = 0\"");
                    int a = 0;
                    do
                    {
                        Console.Write("\r\nPlease enter a = ");
                        a = int.Parse(Console.ReadLine());
                        if (a == 0)
                        {
                            Console.WriteLine("Parameter a must not be equal to zero! Please try again!\r\n");
                        }
                    } while (a == 0);

                    Console.Write("Please enter b = ");
                    int b = int.Parse(Console.ReadLine());

                    decimal equasionResult = ((-b) / (decimal)a);
                    Console.WriteLine("\r\nx = {0:0.00}\r\n", equasionResult);
                    break;

                default:
                    Console.WriteLine("\r\nPlease enter a valid choice in the range [1-3]\r\n");
                    break;
            }
        }



    }
}

