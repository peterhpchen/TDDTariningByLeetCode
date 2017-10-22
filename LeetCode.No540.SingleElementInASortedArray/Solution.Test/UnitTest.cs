using System;
using Xunit;

namespace LeetCode.No540.SingleElementInASortedArray.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void singleNonDuplicateShouldBe(int expected, int[] nums)
        {
            Assert.Equal(expected, _solution.SingleNonDuplicate(nums));
        }

        [Fact]
        public void Expected0WhenNumsIsEmpty()
        {
            int expected = 0;
            int[] nums = new int[] { };

            singleNonDuplicateShouldBe(expected, nums);
        }

        [Fact]
        public void ExpectedNumWhoseIndexIs0WhenTheLengthOfNumsIs1()
        {
            int expected = 5;
            int[] nums = new int[] { 5 };

            singleNonDuplicateShouldBe(expected, nums);
        }

        [Fact]
        public void ExpectedCenterElementWhenTheIndexOfCenterElementIsDivisibleBy2()
        {
            int expected = 2;
            int[] nums = new int[] { 1, 1, 2, 5, 5 };

            singleNonDuplicateShouldBe(expected, nums);
        }
    }
}
