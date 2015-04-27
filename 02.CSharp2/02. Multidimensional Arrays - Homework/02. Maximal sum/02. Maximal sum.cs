//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.IO;

class MaximalSum
{
    static void Main()
    {
        //Read the matrix size & values from the console -----------------------> DISABLED
        ////Console.Write("Please enter the num of rows in the matrix n = ");
        //int n = int.Parse(Console.ReadLine());
        ////Console.Write("Please enter the num of columns in the matrix m = ");
        //int m = int.Parse(Console.ReadLine());

        //int[,] matrix = new int[n, m];

        ////Fill the matrix
        //Console.WriteLine();
        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        //Console.Write("Matrix {{{0}, {1}}} = ", i, j);
        //        matrix[i, j] = int.Parse(Console.ReadLine());
        //    }
        //}

        // Declare and initialize a SAMPLE matrix

        //----------------------> SAMPLE 1 <----------------------
        int[,] matrix = 
        {
            { 2, 4, 0, 9, 500},
            { 1, 3, 20, 20, 20},
            { 3, 9, 20, 20, 20},
            { 0, 7, 20, 20, 20},
            { 6, 700, 20, 20, 20}
        };

        //----------------------> SAMPLE 2 <----------------------
        //int[,] matrix = 
        //{
        //    { 1, 1, 1, 0, 0, 0, 1, 1, 1},
        //    { 1, 0, 1, 0, 0, 0, 1, 0, 1},
        //    { 1, 1, 1, 0, 0, 0, 1, 1, 1},
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0},
        //    { 1, 1, 1, 0, 0, 0, 1, 1, 1},
        //    { 1, 8, 1, 0, 0, 0, 1, 0, 1},
        //    { 1, 1, 1, 0, 0, 0, 1, 1, 1},
        //};

        //Find the square 3 x 3 that holds maximal sum
        int width = 3;
        int height = 3;
        int maxSum = int.MinValue;
        int platformSum = 0;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - height + 1; row++) //holds starting row index
        {
            for (int col = 0; col < matrix.GetLength(1) - width + 1; col++) //holds starting col index
            {
                //Sum the test platform
                for (int platformRow = row; platformRow < row + height; platformRow++)
                {
                    for (int platformCol = col; platformCol < col + width; platformCol++)
                    {
                        platformSum += matrix[platformRow, platformCol];
                    }
                }

                //Update the starting position of the platform if the current platform sum is higher
                if (platformSum > maxSum)
                {
                    maxSum = platformSum;
                    bestRow = row;
                    bestCol = col;
                }
                platformSum = 0;
            }
        }

        //Print the matrix
        PrintMatrix(matrix);

        //Print the platform
        for (int i = bestRow; i < bestRow + width; i++)
        {
            for (int k = bestCol; k < bestCol + height; k++)
            {
                Console.Write("{0} ", matrix[i, k].ToString().PadLeft(3));
            }
            Console.WriteLine();
        }

        //Print max sum
        Console.WriteLine("\r\nPlatform sum = {0}", maxSum);
    }

    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col].ToString().PadLeft(3));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

