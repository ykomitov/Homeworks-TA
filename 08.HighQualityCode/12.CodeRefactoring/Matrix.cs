namespace MatrixWalkTask
{
    using System;

    public class Matrix
    {
        private const int NumberOfPossibleMoves = 8;
        private int lastInputValue = 1;
        private readonly int[,] innerArray;

        public Matrix(int n)
        {
            this.innerArray = this.CreateMatrix(n);
        }

        private int LastInputValue
        {
            get
            {
                return this.lastInputValue;
            }
            set
            {
                this.lastInputValue = value;
            }
        }

        public int[,] GetMatrix()
        {
            return this.innerArray;
        }

        private int[] ValidMovesRow()
        {
            return new int[] { 1, 1, 1, 0, -1, -1, -1, 0 };
        }

        private int[] ValidMovesCol()
        {
            return new int[] { 1, 0, -1, -1, -1, 0, 1, 1 };
        }

        private int[,] CreateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int row = 0,
            col = 0;

            this.FillMatrixCells(matrix, row, col);

            var nextStartPosition = this.FindNextStartPosition(matrix);
            row = nextStartPosition[0];
            col = nextStartPosition[1];

            this.FillMatrixCells(matrix, row, col);

            return matrix;
        }

        private void FillMatrixCells(int[,] matrix, int startRow, int startCol)
        {
            int startRowOfMatrix = startRow;
            int startColOfMatrix = startCol;
            int directionX = 1;
            int directionY = 1;

            while (true)
            {
                if (startRowOfMatrix >= 0 && startColOfMatrix >= 0)
                {
                    matrix[startRowOfMatrix, startColOfMatrix] = this.GetLastInputValue();
                }

                if (!this.IsNextCellEmpty(matrix, startRowOfMatrix, startColOfMatrix))
                {
                    break;
                }

                while (startRowOfMatrix + directionX >= matrix.GetLength(0) || startRowOfMatrix + directionX < 0 || startColOfMatrix + directionY >= matrix.GetLength(1) || startColOfMatrix + directionY < 0 || matrix[startRowOfMatrix + directionX, startColOfMatrix + directionY] != 0)
                {
                    int[] newDirection = this.GetNewDirection(directionX, directionY);
                    directionX = newDirection[0];
                    directionY = newDirection[1];
                }

                startRowOfMatrix += directionX;
                startColOfMatrix += directionY;
            }
        }

        private int GetLastInputValue()
        {
            var inputValue = this.LastInputValue;
            this.LastInputValue++;
            return inputValue;
        }

        private int[] GetNewDirection(int dx, int dy)
        {
            int[] newDirection = { dx, dy };
            int[] dirX = this.ValidMovesRow();
            int[] dirY = this.ValidMovesCol();
            int currentDirectionIndexInArray = 0;

            for (int count = 0; count < NumberOfPossibleMoves; count++)
            {
                if (dirX[count] == dx && dirY[count] == dy)
                {
                    currentDirectionIndexInArray = count;
                    break;
                }
            }

            if (currentDirectionIndexInArray == 7)
            {
                newDirection[0] = dirX[0];
                newDirection[1] = dirY[0];

                return newDirection;
            }

            newDirection[0] = dirX[currentDirectionIndexInArray + 1];
            newDirection[1] = dirY[currentDirectionIndexInArray + 1];

            return newDirection;
        }

        private bool IsNextCellEmpty(int[,] arr, int row, int col)
        {
            if (row < 0 || col < 0)
            {
                return false;
            }

            int[] movesRow = this.ValidMovesRow();
            int[] movesCol = this.ValidMovesCol();

            for (int i = 0; i < NumberOfPossibleMoves; i++)
            {
                if (row + movesRow[i] >= arr.GetLength(0) || row + movesRow[i] < 0)
                {
                    movesRow[i] = 0;
                }

                if (col + movesCol[i] >= arr.GetLength(1) || col + movesCol[i] < 0)
                {
                    movesCol[i] = 0;
                }

                if (arr[row + movesRow[i], col + movesCol[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private int[] FindNextStartPosition(int[,] matrix)
        {
            int[] nextStartPosition = { -1, -1 };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        nextStartPosition[0] = i;
                        nextStartPosition[1] = j;

                        return nextStartPosition;
                    }
                }
            }

            return nextStartPosition;
        }
    }
}