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
        public void ExpectedElement2and1ArrayWhenTheNumsIsElement2and2()
        {
            int[] nums = new int[] { 2, 2 };
            int[] expected = new int[] { 2, 1 };

            findErrorNumsShouldBe(expected, nums);
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
