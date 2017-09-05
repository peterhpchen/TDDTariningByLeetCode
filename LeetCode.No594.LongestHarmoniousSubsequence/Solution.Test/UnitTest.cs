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

        [Fact]
        public void Expected1WhenNums13()
        {
            findLHSShouldBe(1, new int[] { 1, 3 });
        }

        [Fact]
        public void Expected2WhenNums12()
        {
            findLHSShouldBe(2, new int[] { 1, 2 });
        }
    }
}
