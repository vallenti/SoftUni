using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RotatingWalkInMatrix.Test
{
    [TestClass]
    public class WalkInMatrixTest
    {
        [TestMethod]
        public void TestGenerateMatrixWithSize1_ShouldPass()
        {
            int[,] matrix = WalkInMatrix.FillMatrix(1);

            int[,] expectedResult = { { 1 } };

            CheckMatrix(expectedResult, matrix);
        }

        [TestMethod]
        public void TestGenerateMatrixWithSize2_ShouldPass()
        {
            int[,] matrix = WalkInMatrix.FillMatrix(2);

            int[,] expectedResult = 
            {
                { 1, 4 }, 
                { 3, 2 }
            };

            CheckMatrix(expectedResult, matrix);
        }

        [TestMethod]
        public void TestGenerateMatrixWithSize3_ShouldPass()
        {
            int[,] matrix = WalkInMatrix.FillMatrix(3);

            int[,] expectedResult = 
            { 
                { 1, 7, 8 }, 
                { 6, 2, 9 }, 
                { 5, 4, 3 }
            };

            CheckMatrix(expectedResult, matrix);
        }

        [TestMethod]
        public void TestGenerateMatrixWithSize6_ShouldPass()
        {
            int[,] matrix = WalkInMatrix.FillMatrix(6);

            int[,] expectedResult =
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 36, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 6 }
            };

            CheckMatrix(expectedResult, matrix);
        }

        private void CheckMatrix(int[,] expected, int[,] actual)
        {
            for (int row = 0; row < actual.GetLength(0); row++)
            {
                for (int col = 0; col < actual.GetLength(1); col++)
                {
                    Assert.AreEqual(expected[row, col], actual[row, col]);
                }
            }
        }
    }
}
