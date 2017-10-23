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

        [Fact]
        public void Expected_2_whenNumsIs_1_1_2()
        {
            int expected = 2;
            int[] nums = new int[] { 1, 1, 2 };

            singleNonDuplicateShouldBe(expected, nums);
        }

        [Fact]
        public void Expected_1_whenNumsIs_1_2_2()
        {
            int expected = 1;
            int[] nums = new int[] { 1, 2, 2 };

            singleNonDuplicateShouldBe(expected, nums);
        }

        [Fact]
        public void Expected_2_whenNumsIs_1_1_2_3_3_4_4_8_8()
        {
            int expected = 2;
            int[] nums = new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 };

            singleNonDuplicateShouldBe(expected, nums);
        }

        [Fact]
        public void Expected_10_whenNumsIs_3_3_7_7_10_11_11()
        {
            int expected = 10;
            int[] nums = new int[] { 3, 3, 7, 7, 10, 11, 11 };

            singleNonDuplicateShouldBe(expected, nums);
        }
    }
}
