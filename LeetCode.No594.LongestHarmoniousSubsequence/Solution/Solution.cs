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
            var sortNums = NumList.OrderBy(x => x).ToList();

            int LengthOfLHS = 0;
            int numCount = 0;
            int sortNumsCount = sortNums.Count();

            int i = 0;
            int currentNum = sortNums.ElementAt(i);
            numCount = sortNums.Count(x => x == currentNum);

            while (sortNumsCount > 0)
            {
                if (numCount >= sortNumsCount) break;
                sortNums.RemoveRange(0, numCount);
                sortNumsCount -= numCount;
                int nextNum = sortNums.ElementAt(0);

                int nextNumCount = 0;
                foreach (int sortNum in sortNums)
                {
                    if (nextNum != sortNum) break;
                    nextNumCount++;
                }

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
