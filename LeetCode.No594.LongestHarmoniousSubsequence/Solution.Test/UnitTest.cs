using System;
using Xunit;

namespace LeetCode.No594.LongestHarmoniousSubsequence.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void findLHSShouldBe(int expected, int[] nums)
        {
            Assert.Equal(expected, _solution.FindLHS(nums));
        }

        [Fact]
        public void Expected1WhenLengthOfNums1()
        {
            findLHSShouldBe(1, new int[] { 1 });
        }
    }
}
