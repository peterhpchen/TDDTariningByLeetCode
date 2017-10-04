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
            int allElementCount = matrix.Length;
            int[] result = new int[allElementCount];

            if (allElementCount == 0) return new int[] { };
            if (matrix.GetLength((int)array2D.row) == 1)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    result[i] = matrix[0, i];
                }
                return result;
            }

            if (matrix.GetLength((int)array2D.col) == 1)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    result[i] = matrix[i, 0];
                }
                return result;
            }

            int currentRow = 0;
            int currentCol = 0;

            int rowMove = 0;
            int colMove = 0;

            int rowMaxIndex = matrix.GetUpperBound((int)array2D.row);
            int colMaxIndex = matrix.GetUpperBound((int)array2D.col);

            for (int i = 0; i < matrix.Length; i++)
            {
                currentRow += rowMove;
                currentCol += colMove;

                result[i] = matrix[currentRow, currentCol];

                if (currentRow == rowMaxIndex && currentCol == colMaxIndex) break;

                if (rowMove == 0 && colMove == 0)
                {
                    rowMove = 0;
                    colMove = 1;
                    continue;
                }

                if (rowMove == 0 && colMove == 1)
                {
                    if (currentRow == 0)
                    {
                        rowMove = 1;
                        colMove = -1;
                        continue;
                    }
                    rowMove = -1;
                    colMove = 1;
                    continue;
                }

                if (rowMove == 1 && colMove == -1)
                {
                    if (currentRow == rowMaxIndex)
                    {
                        rowMove = 0;
                        colMove = 1;
                        continue;
                    }

                    if (currentCol == 0)
                    {
                        rowMove = 1;
                        colMove = 0;
                        continue;
                    }
                }

                if (rowMove == 1 && colMove == 0)
                {
                    if (currentCol == colMaxIndex)
                    {
                        rowMove = 1;
                        colMove = -1;
                        continue;
                    }
                    rowMove = -1;
                    colMove = 1;
                    continue;
                }

                if (rowMove == -1 && colMove == 1)
                {
                    if (currentCol == colMaxIndex)
                    {
                        rowMove = 1;
                        colMove = 0;
                        continue;
                    }
                    if (currentRow == 0)
                    {
                        rowMove = 0;
                        colMove = 1;
                        continue;
                    }
                }
            }
            return result;
        }
    }
}
