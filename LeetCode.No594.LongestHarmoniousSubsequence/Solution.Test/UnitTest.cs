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
            findLHSShouldBe(0, new int[] { 1 });
        }

        [Fact]
        public void Expected1WhenNums13()
        {
            findLHSShouldBe(0, new int[] { 1, 3 });
        }

        [Fact]
        public void Expected2WhenNums12()
        {
            findLHSShouldBe(2, new int[] { 1, 2 });
        }

        [Fact]
        public void Expected2WhenNums123()
        {
            findLHSShouldBe(2, new int[] { 1, 2, 3 });
        }

        [Fact]
        public void Expected3WhenNums1223()
        {
            findLHSShouldBe(3, new int[] { 1, 2, 2, 3 });
        }

        [Fact]
        public void Expected0WhenNumsNull()
        {
            findLHSShouldBe(0, new int[] { });
        }

        [Fact]
        public void Expected7WhenNumsHaveNegativeNum()
        {
            findLHSShouldBe(7, new int[] { -1, 0, -1, 0, -1, 0, -1 });
        }

        [Fact]
        public void ExpectedLHSWhenSameNumsLengthMoreThanLHS()
        {
            findLHSShouldBe(2, new int[] { 1, 4, 1, 3, 1, -14, 1, -13 });
        }

        [Fact]
        public void TLEProblem()
        {
            findLHSShouldBe(0, new int[] { 11702305, 84420925, 37477084, 27336327, 72660336, 59126505, 5750846, 32621729, 661313, 33925857 });
        }

        [Fact]
        public void Expected0WhenNums1111()
        {
            findLHSShouldBe(0, new int[] { 1, 1, 1, 1 });
        }
    }
}
