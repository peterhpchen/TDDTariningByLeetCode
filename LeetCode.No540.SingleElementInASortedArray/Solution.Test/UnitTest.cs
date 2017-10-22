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
    }
}
