using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.No40.CombinationSumII.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void CombinationSum2ShouldBe(IList<IList<int>> expected, int[] candidates, int target)
        {
            Assert.Equal(expected, _solution.CombinationSum2(candidates, target));
        }
    }
}
