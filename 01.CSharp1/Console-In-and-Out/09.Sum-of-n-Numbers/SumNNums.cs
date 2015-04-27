using System;

/*	Write a program that enters a number `n` and after that enters more `n` numbers and calculates and prints their `sum`.
_Note: You may need to use a for-loop._

_Examples:_

| numbers | sum |
|---------|-----|
| 3       | 90  |
| 20      |     |
| 60      |     |
| 10      |     |
| 5       | 6.5 |
| 2       |     |
| -1      |     |
| -0.5    |     |
| 4       |     |
| 2       |     |
| 1       | 1   |
| 1       |     |*/

class SumNNums
{
    static void Main()
    {
        double sum = 0;
        Console.Write("Please enter an integer n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number to be summed: ");
            double input = double.Parse(Console.ReadLine());
            sum += input;
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}
