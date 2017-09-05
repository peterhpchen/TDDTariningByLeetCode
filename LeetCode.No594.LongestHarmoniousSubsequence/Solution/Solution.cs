using System;
using System.Linq;

namespace LeetCode.No594.LongestHarmoniousSubsequence.Solution
{
    public class Solution
    {
        public int FindLHS(int[] nums)
        {
            if (nums.Length <= 1) return 0;

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
                int count = countArray[i];
                int nextCount = countArray[i + 1];

                if (count == 0 || nextCount == 0) continue;
                int thisLength = count + nextCount;
                if (thisLength > LengthOfLHS) LengthOfLHS = thisLength;
            }

            if (LengthOfLHS == 1) return 0;
            return LengthOfLHS;
        }
    }
}
