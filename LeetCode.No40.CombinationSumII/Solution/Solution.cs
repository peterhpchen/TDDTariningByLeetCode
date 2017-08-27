using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.No40.CombinationSumII.Solution
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();

            foreach (int candidate in candidates)
            {
                if (candidate != target) continue;
                result.Add(new List<int>() { candidate });
            }

            return result;
        }
    }
}
