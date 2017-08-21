using System;

namespace LeetCode.No476.NumberComplement.Solution
{
    public class Solution
    {
        public int FindComplement(int num)
        {
            int binaryLength = Convert.ToString(num, 2).Length;
            int all1BinaryNum = (int)Math.Pow(2, binaryLength) - 1;
            return num ^ all1BinaryNum;
        }
    }
}
