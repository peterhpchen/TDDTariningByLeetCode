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
            
            for (int i = 0; i < sortNums.Count(); i += numCount)
            {
                int currentNum = sortNums.ElementAt(i);

                numCount = sortNums.Count(x => x == currentNum);

                int nextNum = sortNums.ElementAt(numCount);

                if (nextNum - currentNum != 1) continue;
                int HS = numCount + sortNums.Count(x => x == nextNum);
                
                if (HS > LengthOfLHS) LengthOfLHS = HS;
            }

            if (LengthOfLHS == 1) return 0;
            return LengthOfLHS;
        }
    }
}
