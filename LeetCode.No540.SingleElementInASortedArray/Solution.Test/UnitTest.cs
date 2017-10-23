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
        public void Expected_2_whenNumsIs_1_1_2_5_5()
        {
            int expected = 2;
            int[] nums = new int[] { 1, 1, 2, 5, 5 };

            singleNonDuplicateShouldBe(expected, nums);
        }

        [Fact]
        public void Expected_1_whenNumsIs_1_2_2_5_5()
        {
            int expected = 1;
            int[] nums = new int[] { 1, 2, 2, 5, 5 };

            singleNonDuplicateShouldBe(expected, nums);
        }

        [Fact]
        public void Expected_5_whenNumsIs_1_1_2_2_5()
        {
            int expected = 5;
            int[] nums = new int[] { 1, 1, 2, 2, 5 };

            singleNonDuplicateShouldBe(expected, nums);
        }
    }
}
