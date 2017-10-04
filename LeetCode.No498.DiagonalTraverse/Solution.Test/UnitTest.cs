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
        public void expectedEmptyArrayWhenMatrixIsEmpty()
        {
            int[,] matrix = new int[,] { { } };
            int[] expected = new int[] { };

            findDiagonalOrderShouldBe(expected, matrix);
        }
    }
}
