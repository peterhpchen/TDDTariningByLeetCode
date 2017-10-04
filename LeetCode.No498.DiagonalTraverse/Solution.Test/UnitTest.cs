using System;
using Xunit;

namespace LeetCode.No498.DiagonalTraverse.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void findDiagonalOrderShouldBe(int[] expected, int[,] matrix)
        {
            Assert.Equal(expected, _solution.FindDiagonalOrder(matrix));
        }


        [Fact]
        public void expectedCombinedColArrayWhenTheLengthOfRowOfMatrixIsAll1()
        {
            int[,] matrix = new int[,] { { 1 }, { 2 }, { 3 } };
            int[] expected = new int[] { 1, 2, 3 };

            findDiagonalOrderShouldBe(expected, matrix);
        }

        [Fact]
        public void expectedFirstRowArrayWhenMatrixIsOnlyOneRow()
        {
            int[,] matrix = new int[,] { { 1, 2, 3 } };
            int[] expected = new int[] { 1, 2, 3 };

            findDiagonalOrderShouldBe(expected, matrix);
        }

        [Fact]
        public void expectedEmptyArrayWhenMatrixIsEmpty()
        {
            int[,] matrix = new int[,] { { } };
            int[] expected = new int[] { };

            findDiagonalOrderShouldBe(expected, matrix);
        }
    }
}
