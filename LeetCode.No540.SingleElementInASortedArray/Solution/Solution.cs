using System;

namespace LeetCode.No540.SingleElementInASortedArray.Solution
{
    public class Solution
    {
        public int SingleNonDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            throw new NotImplementedException();
        }
    }
}
