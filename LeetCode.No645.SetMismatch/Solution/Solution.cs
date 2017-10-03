using System;
using System.Linq;

namespace LeetCode.No645.SetMismatch.Solution
{
    public class Solution
    {
        public int[] FindErrorNums(int[] nums)
        {
            int length = nums.Length;

            if (length < 2) return new int[] { };

            int[] checkArray = new int[length];
            int[] result = new int[2];

            foreach (int num in nums)
            {
                int index = num - 1;
                if (checkArray[index] == 0)
                {
                    checkArray[index] = num;
                    continue;
                }
                result[0] = num;
            }

            for (int i = 0; i < checkArray.Length; i++)
            {
                if (checkArray[i] != 0) continue;
                result[1] = i + 1;
                break;
            }

            return result;
        }
    }
}
