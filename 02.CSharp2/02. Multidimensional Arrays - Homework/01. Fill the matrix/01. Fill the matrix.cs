/*Write a program that fills and prints a matrix of size (n, n) 
a) 	                    b)                  	c) 
1 	5 	9 	13          1 	8 	9 	16          7 	11 	14 	16
2 	6 	10 	14          2 	7 	10 	15          4 	8 	12 	15
3 	7 	11 	15          3 	6 	11 	14          2 	5 	9 	13
4 	8 	12 	16          4 	5 	12 	13          1 	3 	6 	10*/

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Please enter the size of the matrix n = ");
        int n = int.Parse(Console.ReadLine());

        //Initialize matrices A, B & C
        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];
        int[,] matrixC = new int[n, n];

        //Fill matrix A
        int begin = 0;
        for (int col = 0; col < matrixA.GetLength(1); col++)
        {
            for (int row = 0; row < matrixA.GetLength(0); row++)
            {
                matrixA[row, col] = begin + row + 1;
            }
            begin += n;
        }

        //Fill matrix B
        begin = 0;
        int endValue = 0;
        int beginOddCols = 0;
        for (int col = 0; col < matrixB.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrixB.GetLength(0); row++)
                {
                    matrixB[row, col] = begin + row + 1;
                    endValue = matrixB[row, col];
                }
                begin += n;
                beginOddCols = endValue + 1;
            }
            else
            {
                for (int row = matrixB.GetLength(0) - 1; row >= 0; row--)
                {
                    matrixB[row, col] = beginOddCols;
                    beginOddCols++;
                }
                begin += n;
            }
        }

        //Fill matrix C
        int numCount = 1; //Stops the while loop after all numbers are in place

        //Variables to fill numbers from the lower left corner until the middle diagonal
        int rowEnd = n - 1; //initial row index
        int colStart = 0; //initial col index
        int diagonalIncreasing = 1; //for loop terminator
        int rowDiagonal = 0; //Row index
        int colDiagonal = 0; //Col index

        //Variables to fill numbers from upper right corner down towards the middle of the matrix
        int endValueMatrixC = n * n; //Value of the top right corner
        int diagonalDecreasing = 2; //for loop terminator
        int rowUpperCorner = 0; //Row index
        int colUpperCorner = n - 1; //Col index
        int kOut = 0; //var to calculate the starting row index of each diagonal

        while (numCount <= n * n)
        {
            //Fill the lower left corner
            if (diagonalIncreasing == 1)
            {
                matrixC[rowEnd, colStart] = numCount;
                numCount++;
                diagonalIncreasing++;
                rowEnd--;
            }
            //Fill diagonals from lower left corner until the middle of Matrix C
            if (rowEnd >= 0)
            {
                rowDiagonal = rowEnd;
                colDiagonal = colStart;
                for (int j = 0; j < diagonalIncreasing; j++)
                {
                    matrixC[rowDiagonal, colDiagonal] = numCount;
                    rowDiagonal++;
                    colDiagonal++;
                    numCount++;
                }
                rowEnd--;
                diagonalIncreasing++;
            }
            //Fill upper right corner
            if (colDiagonal == n)
            {
                matrixC[rowUpperCorner, colUpperCorner] = endValueMatrixC;
                numCount++;
                endValueMatrixC--;
                colDiagonal++;
                rowUpperCorner++;

            }
            //Fill diagonals down from upper right corner
            if (colDiagonal > n)
            {
                for (int k = 0; k < diagonalDecreasing; k++)
                {
                    matrixC[rowUpperCorner, colUpperCorner] = endValueMatrixC;
                    rowUpperCorner--;
                    colUpperCorner--;
                    endValueMatrixC--;
                    numCount++;
                    kOut = k;
                }
                diagonalDecreasing++;
                rowUpperCorner = kOut + 1;
                colUpperCorner = n - 1;
            }
        }


        //Print matrices A, B & C
        PrintMatrix(matrixA);
        PrintMatrix(matrixB);
        PrintMatrix(matrixC);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col].ToString().PadLeft(2));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

