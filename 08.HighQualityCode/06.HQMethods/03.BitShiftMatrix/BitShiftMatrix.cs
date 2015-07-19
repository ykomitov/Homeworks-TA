namespace _03.BitShiftMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    internal class Problem3
    {
        internal static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int numberOfMoves = int.Parse(Console.ReadLine());
            decimal[] encodedMoves = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            // Create & fill the matrix with values according to the problem conditions
            double[,] matrix = new double[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Math.Pow(2, (double)rows - ((double)row + 1)) * Math.Pow(2, (double)col);
                }
            }

            // Traverse the matrix and sum the cell values. When a cell is visited, its value is replaced with 0
            int startRow = rows - 1;
            int startCol = 0;
            BigInteger sum = 0;
            int coeff = Math.Max(rows, cols);

            foreach (var position in encodedMoves)
            {
                int targetRow = (int)position / coeff;
                int targetCol = (int)position % coeff;

                if (startCol < targetCol)
                {
                    while (true)
                    {
                        sum += (BigInteger)matrix[startRow, startCol];
                        matrix[startRow, startCol] = 0;

                        if (startCol == targetCol)
                        {
                            break;
                        }

                        startCol++;
                    }
                }

                if (startCol > targetCol)
                {
                    while (true)
                    {
                        sum += (BigInteger)matrix[startRow, startCol];
                        matrix[startRow, startCol] = 0;

                        if (startCol == targetCol)
                        {
                            break;
                        }

                        startCol--;
                    }
                }

                if (startRow < targetRow)
                {
                    while (true)
                    {
                        sum += (BigInteger)matrix[startRow, startCol];
                        matrix[startRow, startCol] = 0;

                        if (startRow == targetRow)
                        {
                            break;
                        }

                        startRow++;
                    }
                }

                if (startRow > targetRow)
                {
                    while (true)
                    {
                        sum += (BigInteger)matrix[startRow, startCol];
                        matrix[startRow, startCol] = 0;

                        if (startRow == targetRow)
                        {
                            break;
                        }

                        startRow--;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
