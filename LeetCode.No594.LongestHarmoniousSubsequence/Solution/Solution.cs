using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode.No594.LongestHarmoniousSubsequence.Solution
{
    public class Solution
    {
        public int FindLHS(int[] nums)
        {
            if (nums.Length <= 1) return 0;

            List<int> NumList = nums.ToList();
            var sortNums = NumList.OrderBy(x => x);

            int LengthOfLHS = 0;
            int numCount = 0;
            int sortNumsCount = sortNums.Count();

            int i = 0;
            int currentNum = sortNums.ElementAt(i);
            numCount = sortNums.Count(x => x == currentNum);

            while (i < sortNumsCount)
            {
                i += numCount;

                if (i >= sortNumsCount) break;
                int nextNum = sortNums.ElementAt(i);

                int nextNumCount = sortNums.Count(x => x == nextNum);

                if (nextNum - currentNum == 1)
                {
                    int HS = numCount + nextNumCount;
                    if (HS > LengthOfLHS) LengthOfLHS = HS;
                }

                currentNum = nextNum;
                numCount = nextNumCount;
            }

            if (LengthOfLHS == 1) return 0;
            return LengthOfLHS;
        }
    }
}
