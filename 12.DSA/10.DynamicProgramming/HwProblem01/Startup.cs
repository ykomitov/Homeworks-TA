/*Write a program based on dynamic programming to solve the "Knapsack Problem": you are given N products, each has weight Wi and costs Ci and a knapsack of capacity M and you want to put inside a subset of the products with highest cost and weight ≤ M. The numbers N, M, Wi and Ci are integers in the range [1..500].

    Example: M=10kg, N=6, products:
        beer – weight=3, cost=2
        vodka – weight=8, cost=12
        cheese – weight=4, cost=5
        nuts – weight=1, cost=4
        ham – weight=2, cost=3
        whiskey – weight=8, cost=13
    Optimal solution:
        nuts + whiskey
        weight = 9
        cost = 17
*/

namespace HwProblem01
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            // Store weights & costs in 2 arrays of equal length. The length is equal to the number of items to choose from
            var weights = new int[] { 3, 8, 4, 1, 2, 8 };
            var costs = new int[] { 2, 12, 5, 4, 3, 13 };
            int knapsackCapacity = 10;
            int numOfItems = 6;

            // Store answers in a table
            var matrix = new int[numOfItems, knapsackCapacity];

            for (int i = 1; i < numOfItems; i++)
            {
                for (int j = 0; j < knapsackCapacity; j++)
                {
                    if (weights[i] <= j)
                    {
                        matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i - 1, j - weights[i]] + costs[i]);
                    }
                    else
                    {
                        matrix[i, j] = matrix[i - 1, j];
                    }
                }
            }

            Console.WriteLine(matrix[numOfItems - 1, knapsackCapacity - 1]);
        }
    }
}
