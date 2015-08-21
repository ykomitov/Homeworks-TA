namespace MatrixWalkTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MatrixWalkTask;

    [TestClass]
    public class MatrixWalkUnitTests
    {
        [TestMethod]
        public void TestIfOutputMatrixEqualsMatrixInExample()
        {
            int matrixSize = 6;        

            int[,] matrixFromExample = 
            {
                {1,  16, 17, 18, 19, 20},
                {15,  2, 27, 28, 29, 21},
                {14, 31,  3, 26, 30, 22},
                {13, 36, 32,  4, 25, 23},
                {12, 35, 34, 33,  5, 24},
                {11, 10,  9,  8,  7,  6}};

            var matrix = new Matrix(matrixSize);

            bool areSame = CompareSquareMatrices(matrix.GetMatrix(), matrixFromExample);

            Assert.IsTrue(areSame);
        }

        [TestMethod]
        public void TestIfOutputMatrixEqualsInitialCodeOutputMatrix()
        {
            int matrixSize = 3;

            int[,] initialCodeOutput = 
            {
                {1,7,8},
                {6,2,9},
                {5,4,3}};

            var matrix3x3 = new Matrix(matrixSize);

            bool areSame = CompareSquareMatrices(matrix3x3.GetMatrix(), initialCodeOutput);

            Assert.IsTrue(areSame);
        }

        public bool CompareSquareMatrices(int[,] m1, int[,] m2)
        {
            bool areSame = true;

            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    if (m1[i, j] != m2[i, j])
                    {
                        areSame = false;
                        break;
                    }
                }
            }

            return areSame;
        }
    }
}
