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

            int centerIndex = length / 2;

            if (centerIndex % 2 == 0)
            {
                int currentNum = nums[centerIndex];
                int previousNum = nums[centerIndex - 1];
                int afterNum = nums[centerIndex + 1];

                if (currentNum != previousNum && currentNum != afterNum) return currentNum;
                int lengthOfNextNums = centerIndex - 1;
                int[] nextNums = new int[centerIndex - 1];
                if (currentNum == previousNum) Array.Copy(nums, nextNums, centerIndex - 1);
                if (currentNum == afterNum) Array.Copy(nums, centerIndex + 2, nextNums, 0, centerIndex - 1);
                return SingleNonDuplicate(nextNums);
            }

            throw new NotImplementedException();
        }
    }
}
