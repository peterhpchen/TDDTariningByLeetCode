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
            int currentNum = nums[centerIndex];
            int previousNum = nums[centerIndex - 1];
            int afterNum = nums[centerIndex + 1];

            int lengthOfNextNums = centerIndex - 1;
            int[] nextNums = new int[lengthOfNextNums];
            if (centerIndex % 2 == 0)
            {
                if (currentNum != previousNum && currentNum != afterNum) return currentNum;

                if (currentNum == previousNum) Array.Copy(nums, nextNums, lengthOfNextNums);
                if (currentNum == afterNum) Array.Copy(nums, centerIndex + 2, nextNums, 0, lengthOfNextNums);
                return SingleNonDuplicate(nextNums);
            }

            lengthOfNextNums = centerIndex;
            nextNums = new int[lengthOfNextNums];

            if (currentNum == previousNum) Array.Copy(nums, centerIndex + 1, nextNums, 0, lengthOfNextNums);
            if (currentNum == afterNum) Array.Copy(nums, nextNums, lengthOfNextNums);
            return SingleNonDuplicate(nextNums);
        }
    }
}
