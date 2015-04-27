namespace Matrix
{
    using System;
    using System.Text;

    /*  Problem 8. Matrix
        Define a class `Matrix<T>` to hold a matrix of numbers (e.g. integers, floats, decimals).*/

    class Matrix<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
            {
                throw new ArgumentOutOfRangeException("The number of rows and colums should be > 0!");
            }
            this.matrix = new T[rows, cols];
            this.cols = cols;
            this.rows = rows;
        }

        public Matrix(T[,] input)
        {
            this.rows = input.GetLength(0);
            this.cols = input.GetLength(1);
            this.matrix = input;
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
        }
        public int Cols
        {
            get
            {
                return this.cols;
            }
        }

        /*  Problem 9. Matrix indexer
            Implement an indexer `this[row, col]` to access the inner matrix cells.*/
        public T this[int indexRow, int indexCol]
        {
            get
            {
                //check if indexes enterned are valid for the matrix
                if ((indexRow < 0) || indexRow > this.Rows - 1)
                {
                    throw new IndexOutOfRangeException(string.Format("Row index must be between[0; {0}]!", this.Rows - 1));
                }
                if ((indexCol < 0) || indexCol > this.Cols - 1)
                {
                    throw new IndexOutOfRangeException(string.Format("Column index must be between[0; {0}]!", this.Cols - 1));
                }
                return this.matrix[indexRow, indexCol];
            }

            set
            {
                //copy-pasted code... not sure how to avoid this 
                if ((indexRow < 0) || indexRow > this.Rows - 1)
                {
                    throw new IndexOutOfRangeException(string.Format("Row index must be between[0; {0}]!", this.Rows - 1));
                }
                if ((indexCol < 0) || indexCol > this.Cols - 1)
                {
                    throw new IndexOutOfRangeException(string.Format("Column index must be between[0; {0}]!", this.Cols - 1));
                }
                this.matrix[indexRow, indexCol] = value;
            }
        }

        /*  Problem 10. Matrix operations
            Implement the operators `+` and `-` (addition and subtraction of matrices of the same size) and `*` for matrix multiplication.
            Throw an exception when the operation cannot be performed.
            Implement the `true` operator (check for non-zero elements).*/
        private Matrix<T> Sum(Matrix<T> matrix)
        {
            if (this.Rows != matrix.Rows || this.Cols != matrix.Cols)
            {
                throw new Exception("Matrices are not the same size!");
            }
            else
            {
                var resultMatrix = new Matrix<T>(this.Rows, this.Cols);
                for (int row = 0; row < resultMatrix.Rows; row++)
                {
                    for (int col = 0; col < resultMatrix.Cols; col++)
                    {
                        dynamic m1 = this[row, col];
                        dynamic m2 = matrix[row, col];
                        var result = m1 + m2;
                        resultMatrix[row, col] = result;
                    }
                }
                return resultMatrix;
            }
        }
        private Matrix<T> Substract(Matrix<T> matrix)
        {
            if (this.Rows != matrix.Rows || this.Cols != matrix.Cols)
            {
                throw new Exception("Matrices are not the same size!");
            }
            else
            {
                var resultMatrix = new Matrix<T>(this.Rows, this.Cols);
                for (int row = 0; row < resultMatrix.Rows; row++)
                {
                    for (int col = 0; col < resultMatrix.Cols; col++)
                    {
                        dynamic m1 = this[row, col];
                        dynamic m2 = matrix[row, col];
                        var result = m1 - m2;
                        resultMatrix[row, col] = result;
                    }
                }
                return resultMatrix;
            }
        }
        private Matrix<T> Multiply(Matrix<T> matrix)
        {
            if (this.Rows == 1 && this.Cols == 1)
            {
                var number = this.matrix[0, 0];
                var resultMatrix = new Matrix<T>(matrix.Rows, matrix.Cols);
                for (int row = 0; row < resultMatrix.Rows; row++)
                {
                    for (int col = 0; col < resultMatrix.Cols; col++)
                    {
                        dynamic m1 = number;
                        dynamic m2 = matrix[row, col];
                        var result = m1 * m2;
                        resultMatrix[row, col] = result;
                    }
                }
                return resultMatrix;
            }

            if (this.Cols != matrix.Rows)
            {
                throw new Exception("Matrices cannot be multiplied!");
            }

            else
            {
                var resultMatrix = new Matrix<T>(this.Rows, matrix.Cols);
                for (int row = 0; row < resultMatrix.Rows; row++)
                {
                    for (int col = 0; col < resultMatrix.Cols; col++)
                    {
                        dynamic tempResult = 0;
                        for (int i = 0; i < this.Cols; i++)
                        {
                            tempResult += ((dynamic)this.matrix[row, i] * (dynamic)matrix[i, col]);
                        }
                        resultMatrix[row, col] = tempResult;
                    }
                }
                return resultMatrix;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            var resultMatrix = m1.Sum(m2);
            return resultMatrix;
        }
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            var resultMatrix = m1.Substract(m2);
            return resultMatrix;
        }
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            var resultMatrix = m1.Multiply(m2);
            return resultMatrix;
        }
        public static bool operator true(Matrix<T> matrix)
        {
            bool test = true;

            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        test = false;
                    }
                }
            }
            return test;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            bool test = true;

            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        test = false;
                    }
                }
            }
            return test;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    sb.Append(this.matrix[row, col].ToString().PadLeft(3, ' '));
                    sb.Append(" ");
                }
                sb.Append("\r\n");
            }
            return sb.ToString();
        }
    }
}
