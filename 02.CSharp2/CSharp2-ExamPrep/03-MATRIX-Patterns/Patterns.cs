using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03_MATRIX_Patterns
{
    class Patterns
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];
            var matrixRow = new int[n];

            //fill the matrix
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                matrixRow = input.Split(' ').Select(x => int.Parse(x)).ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = matrixRow[j];
                }
            }

            //calculate sum of main diagonal
            BigInteger diagonalSum = 0;

            for (int i = 0, j = 0; i < n; i++, j++)
            {
                diagonalSum += matrix[i, j];
            }

            //Pattern
            //A = B -1, B = C – 1, C = D – 1, D = F – 1, F = E – 1, E = G - 1

            int patternStartRow = 2;
            int patternStartCol = 4;

            //2,4
            BigInteger patternSum = 0;
            bool patternFound = false;
            BigInteger bestPatternSum = 0;

            for (int i = patternStartRow; i < n; i++)
            {
                for (int j = patternStartCol; j < n; j++)
                {
                    if (matrix[i, j - 1] == (matrix[i, j] - 1) &
                        matrix[i, j - 2] == (matrix[i, j - 1] - 1) &
                        matrix[i - 1, j - 2] == (matrix[i, j - 2] - 1) &
                        matrix[i - 2, j - 2] == (matrix[i - 1, j - 2] - 1) &
                        matrix[i - 2, j - 3] == (matrix[i - 2, j - 2] - 1) &
                        matrix[i - 2, j - 4] == (matrix[i - 2, j - 3] - 1)
                        )
                    {
                        patternSum = matrix[i, j] +
                                     matrix[i, j - 1] +
                                     matrix[i, j - 2] +
                                     matrix[i - 1, j - 2] +
                                     matrix[i - 2, j - 2] +
                                     matrix[i - 2, j - 3] +
                                     matrix[i - 2, j - 4];
                        patternFound = true;
                    }

                    if (patternSum > bestPatternSum)
                    {
                        bestPatternSum = patternSum;
                    }
                }
            }

            if (patternFound == true)
            {
                Console.WriteLine("YES {0}", bestPatternSum);
            }
            else
            {
                Console.WriteLine("NO {0}", diagonalSum);
            }
        }
    }
}
