using System;

/*	Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

_Examples:_

|      numbers      |  sum  |
|-------------------|-------|
| 1 2 3 4 5         | 15    |
| 10 10 10 10 10    | 50    |
| 1.5 3.14 8.2 -1 0 | 11.84 |*/

class SumNumbers
{
    static void Main()
    {
        Console.Write("Please input 5 numbers on a single line, separated by spaces: ");
        char separator = ' ';
        string input = Console.ReadLine();
        double sum = 0;

        while (input.Contains("  ")) //check if string contains double spaces and removes them
        {
            input = input.Replace("  ", " ");
        }
        input = input.Trim(); //trim any leading or trailing spaces

        //split the input string and populate array splittedInput
        string[] splittedInput = input.Split(separator);

        //Itterate through array splittedInput to calculate the sum
        for (int i = 0; i < splittedInput.Length; i++)
        {
            sum = sum + double.Parse(splittedInput[i]);
        }
        Console.WriteLine("The sum of the enterned numbers is {0}.", sum);
    }
}
