/* We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
 * Write a program that finds the longest sequence of equal strings in the matrix.*/

using System;
using System.Linq;

class SequenceNMatrix
{
    static string bestString = string.Empty;
    static string finalSequence = string.Empty;
    static int maxRepetitions = 0;

    static void Main()
    {
        ////Read the matrix size & values from the console -----------------------> DISABLED
        //Console.Write("Please enter the num of rows in the matrix n = ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("Please enter the num of columns in the matrix m = ");
        //int m = int.Parse(Console.ReadLine());

        //string[,] matrix = new string[n, m];

        ////Fill the matrix
        //Console.WriteLine();
        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        Console.Write("Matrix {{{0}, {1}}} = ", i, j);
        //        matrix[i, j] = Console.ReadLine();
        //    }
        //}

        //Sample matrix 1
        string[,] matrix = 
        {
            {"ha", "fi", "ho", "ho"}, 	
            {"fo", "ha", "ho", "xx"},
            {"xx", "ho", "ha", "xx"},
            {"xx", "ho", "ho", "ha"},
            {"ex", "oh", "ho", "xx"},
            {"xx", "ho", "oh", "xx"}
        };

        //Sample matrix 2
        //string[,] matrix = 
        //{
        //    {"s", "qq", "s"}, 	
        //    {"pp", "pp", "s"},
        //    {"pp", "qq", "s"}
        //};

        //Print the input matrix
        PrintMatrix(matrix);

        //Check horizontal, vertical & diagonal from each element in the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                BestSequence(matrix, row, col);
            }
        }
        Console.WriteLine("Longest sequence is: \"{0}\"\r\n", finalSequence);
    }

    static int CheckHorizontal(string[,] matrix, int row, int col)
    {
        int counter = 0;
        string beginValue = matrix[row, col];
        for (int i = col; i < matrix.GetLength(1); i++)
        {
            if (beginValue == matrix[row, i])
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        return counter;
    }

    static int CheckVertical(string[,] matrix, int row, int col)
    {
        int counter = 0;
        string beginValue = matrix[row, col];
        for (int i = row; i < matrix.GetLength(0); i++)
        {
            if (beginValue == matrix[i, col])
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        return counter;
    }

    static int CheckDiagonal(string[,] matrix, int row, int col)
    {
        int counter = 0;
        string beginValue = matrix[row, col];
        for (int i = row, j = col; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
        {
            if (beginValue == matrix[i, j])
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        return counter;
    }

    static void BestSequence(string[,] matrix, int row, int col)
    {
        //Check for repeating sequence in all directions from the current position
        int bestHorizontal = CheckHorizontal(matrix, row, col);
        int bestVertical = CheckVertical(matrix, row, col);
        int bestDiagonal = CheckDiagonal(matrix, row, col);

        //If longer sequence is found update maxRepetitions & bestString
        if (bestHorizontal > maxRepetitions)
        {
            maxRepetitions = bestHorizontal;
            bestString = matrix[row, col];
        }
        if (bestVertical > maxRepetitions)
        {
            maxRepetitions = bestVertical;
            bestString = matrix[row, col];
        }
        if (bestDiagonal > maxRepetitions)
        {
            maxRepetitions = bestDiagonal;
            bestString = matrix[row, col];
        }

        //Build the longest string found in the matrix
        finalSequence = string.Join(", ", Enumerable.Repeat(bestString, maxRepetitions).ToArray());
    }

    static void PrintMatrix(string[,] matrix)
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

