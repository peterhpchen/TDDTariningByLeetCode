using System;

namespace LeetCode.No540.SingleElementInASortedArray.Solution
{
    public class Solution
    {
        public int SingleNonDuplicate(int[] nums)
        {
            int length = nums.Length;

            if (nums == null || length == 0) return 0;
            if (length == 1) return nums[0];

            int currentIndex = length / 2;

            if (currentIndex % 2 == 0)
            {
                int currentNum = nums[currentIndex];
                if (currentNum != nums[currentIndex - 1] && currentNum != nums[currentIndex + 1]) return currentNum;
            }

            throw new NotImplementedException();
        }
    }
}
