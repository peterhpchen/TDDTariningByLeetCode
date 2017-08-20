using System;

namespace LeetCode.No476.NumberComplement.Solution
{
    public class Solution
    {
        public int FindComplement(int num)
        {
            int binaryLength = Convert.ToString(num, 2).Length;
            if (binaryLength == 1) return num ^ 1;
            int full1BinaryNum = (int)Math.Pow(2, binaryLength) - 1;
            return num ^ full1BinaryNum;
        }
    }
}
