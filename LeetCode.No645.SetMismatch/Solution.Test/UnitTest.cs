using System;
using Xunit;

namespace LeetCode.No645.SetMismatch.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();
        private void findErrorNumsShouldBe(int[] expected, int[] nums)
        {
            Assert.Equal(expected, _solution.FindErrorNums(nums));
        }

        [Fact]
        public void ExpectedEmptyArrayWhenTheLengthOfNumsLessThan1()
        {
            int[] nums = new int[] { 1 };
            int[] expected = new int[] { };

            findErrorNumsShouldBe(expected, nums);

            nums = new int[] { };

            findErrorNumsShouldBe(expected, nums);
        }
    }
}
