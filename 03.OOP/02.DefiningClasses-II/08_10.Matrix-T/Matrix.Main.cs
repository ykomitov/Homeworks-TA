namespace Matrix
{
    using System;

    class MatrixMain
    {
        static void Main()
        {
            /*### Problem 8. Matrix
             * Define a class `Matrix<T>` to hold a matrix of numbers (e.g. integers, floats, decimals). */

            var testMatrix = new Matrix<decimal>(new decimal[,] 
            {  {0,1,2},
               {9,8,7}
            });

            var anotherMatrix = new Matrix<decimal>(new decimal[,]
            {  {6,5,4},
               {3,4,5}
            });

            /*### Problem 9. Matrix indexer
             * Implement an indexer `this[row, col]` to access the inner matrix cells.*/

            Console.WriteLine("==================\r\nTest indexer\r\n==================");
            Console.WriteLine(testMatrix);
            Console.WriteLine("matrix [0,1] = {0}\r\n\r\n", testMatrix[0, 1]);

            /*### Problem 10. Matrix operations
             * Implement the operators `+` and `-` (of matrices of the same size) and `*` for matrix multiplication.
             * Throw an exception when the operation cannot be performed.
             * Implement the `true` operator (check for non-zero elements).*/

            Console.WriteLine("==================\r\nTest + operator\r\n==================");
            var resultAddition = testMatrix + anotherMatrix;

            Console.WriteLine(testMatrix);
            Console.WriteLine("+\r\n");
            Console.WriteLine(anotherMatrix);
            Console.WriteLine("=\r\n");
            Console.WriteLine(resultAddition);

            Console.WriteLine("==================\r\nTest - operator\r\n==================");
            var resultSubstraction = testMatrix - anotherMatrix;

            Console.WriteLine(testMatrix);
            Console.WriteLine("-\r\n");
            Console.WriteLine(anotherMatrix);
            Console.WriteLine("=\r\n");
            Console.WriteLine(resultSubstraction);

            //Initialize 2 matrices to test multiplication
            var mult1 = new Matrix<decimal>(new decimal[,] 
                {  {3,4,2}
                });

            var mult2 = new Matrix<decimal>(new decimal[,] 
                {  {13,9,7,15},
                   {8,7,4,6},
                   {6,4,0,3}
                });

            Console.WriteLine("==================\r\nTest * operator\r\n==================");
            var resultMultiplication = mult1 * mult2;

            Console.WriteLine(mult1);
            Console.WriteLine("*\r\n");
            Console.WriteLine(mult2);
            Console.WriteLine("=\r\n");
            Console.WriteLine(resultMultiplication);

            Console.WriteLine("==================\r\nTest true operator\r\n==================");
            //test "true" & "false" operators
            Console.WriteLine("Matrix:\r\n");
            Console.WriteLine(mult2);

            if (mult2)
            {
                Console.WriteLine("Does not contain 0.");
            }
            else
            {
                Console.WriteLine("Contains 0!!!");
            }

            Console.WriteLine();
            Console.WriteLine("Matrix:\r\n");
            Console.WriteLine(mult1);

            if (mult1)
            {
                Console.WriteLine("Does not contain 0.");
            }
            else
            {
                Console.WriteLine("Contains 0!!!");
            }
        }
    }
}