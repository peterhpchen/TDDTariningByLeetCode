using System;
using Xunit;

namespace LeetCode.No406.QueueReconstructionByHeight.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void expectedReconstructionQueueShouldBe(int[,] expected, int[,] people)
        {
            Assert.Equal(expected, _solution.ReconstructQueue(people));
        }

        [Fact]
        public void ExpectedEmptyWhenPeopleIsEmpty()
        {
            int[,] expected = new int[,] { };
            int[,] people = new int[,] { };

            expectedReconstructionQueueShouldBe(expected, people);
        }

        [Fact]
        public void ExpectedSelfWhenTheLengthOfArrayLessThanOne()
        {
            int[,] expected = new int[,] { { 1, 0 } };
            int[,] people = new int[,] { { 1, 0 } };

            expectedReconstructionQueueShouldBe(expected, people);
        }

        [Fact]
        public void ExpectedSortByHWhenAllKIsEqual()
        {
            int[,] expected = new int[,] { { 1, 0 }, { 2, 0 } };
            int[,] people = new int[,] { { 2, 0 }, { 1, 0 } };

            expectedReconstructionQueueShouldBe(expected, people);
        }

        [Fact]
        public void ExpectedSortByKWhenAllHIsEqual()
        {
            int[,] expected = new int[,] { { 1, 0 }, { 1, 1 } };
            int[,] people = new int[,] { { 1, 1 }, { 1, 0 } };

            expectedReconstructionQueueShouldBe(expected, people);
        }

        [Fact]
        public void ExpectedBackKMinusTheLengthOfPersonWhichSameHeightAndKLessThanItself()
        {
            int[,] expected = new int[,] { { 1, 0 }, { 2, 0 }, { 1, 2 } };
            int[,] people = new int[,] { { 2, 0 }, { 1, 2 }, { 1, 0 } };

            expectedReconstructionQueueShouldBe(expected, people);
        }

        [Fact]
        public void LeetCodeExample()
        {
            int[,] expected = new int[,] { { 5, 0 }, { 7, 0 }, { 5, 2 }, { 6, 1 }, { 4, 4 }, { 7, 1 } };
            int[,] people = new int[,] { { 7, 0 }, { 4, 4 }, { 7, 1 }, { 5, 0 }, { 6, 1 }, { 5, 2 } };

            expectedReconstructionQueueShouldBe(expected, people);
        }
    }
}
