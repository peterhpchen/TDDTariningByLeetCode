using System;
using System.Collections.Generic;

namespace LeetCode.No498.DiagonalTraverse.Solution
{
    public class Solution
    {
        private enum array2D
        {
            row = 0,
            col = 1
        };

        public int[] FindDiagonalOrder(int[,] matrix)
        {
            List<int> result = new List<int>();

            if (matrix.Length == 0) return new int[] { };
            if (matrix.GetLength((int)array2D.row) == 1)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    result.Add(matrix[0, i]);
                }
            }
            return result.ToArray();
        }
    }
}
