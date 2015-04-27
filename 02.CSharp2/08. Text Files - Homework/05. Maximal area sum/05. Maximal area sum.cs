/*•	Write a program that reads a text file containing a square matrix of numbers.
  •	Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
    o	The first line in the input file contains the size of matrix N.
    o	Each of the next N lines contain N numbers separated by space.
    o	The output should be a single number in a separate text file.*/

using System;
using System.IO;
using System.Linq;

class MaximalAreaSum
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../square-matrix.txt");

        //read the size of the matrix N & initialize the array
        int matrixsize = int.Parse(reader.ReadLine());
        int[,] matrix = new int[matrixsize, matrixsize];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            //read the input file line by line & fill the matric
            string matrixRow = reader.ReadLine();                              //read a line of the file
            int[] matrixRowArr = matrixRow.Split(' ')
                                        .Select(a => int.Parse(a)).ToArray();  //parse it to a single dimentional array
            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = matrixRowArr[j];
            }
        }

        int maxSum = MaxSumInMatrix(matrix);
        Console.WriteLine("The maximal sum is {0}.", maxSum);

        //initialize StreamWriter
        StreamWriter writer = new StreamWriter("../../max-sum.txt");
        writer.WriteLine(maxSum);
        writer.Flush(); //flush the result to new file
        
        Console.WriteLine("Result successfully saved to ../../max-sum.txt\r\n");
        //close reader & writer
        reader.Close();
        writer.Close();
    }

    static int MaxSumInMatrix(int[,] matrix)
    {
        //Find the square 2 x 2 that holds maximal sum
        int width = 2;
        int height = 2;
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
        return maxSum;
    }
}

