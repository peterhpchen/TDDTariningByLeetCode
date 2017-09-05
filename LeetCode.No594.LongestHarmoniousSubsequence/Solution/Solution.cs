using System;
using System.Linq;

namespace LeetCode.No594.LongestHarmoniousSubsequence.Solution
{
    public class Solution
    {
        public int FindLHS(int[] nums)
        {
            int numsLength = nums.Length;
            if (numsLength <= 1) return numsLength;

            int countArrayIndexStart = nums.Min();
            int countArrayLength = nums.Max() - countArrayIndexStart + 1;
            int[] countArray = new int[countArrayLength];

            foreach (int num in nums)
            {
                countArray[num - countArrayIndexStart] += 1;
            }

            int LengthOfLHS = 0;
            for (int i = 0; i < countArrayLength - 1; i++)
            {
                int thisLength = countArray[i] + countArray[i + 1];
                if (thisLength > LengthOfLHS) LengthOfLHS = thisLength;
            }
            return LengthOfLHS;
        }
    }
}
