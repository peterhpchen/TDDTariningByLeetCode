using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.No40.CombinationSumII.Solution.Test
{
    public class TestDataGenerator
    {
        public static IEnumerable<object[]> Expected1WhenCandidates1Target1()
        {
            yield return new object[] { new List<IList<int>>() { new List<int>() { 1 } }, new int[] { 1 }, 1 };
            yield return new object[] { new List<IList<int>>() { new List<int>() { 1 } }, new int[] { 1, 2 }, 1 };
        }
    }

    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void CombinationSum2ShouldBe(IList<IList<int>> expected, int[] candidates, int target)
        {
            Assert.Equal(expected, _solution.CombinationSum2(candidates, target));
        }

        [Theory]
        [MemberData("Expected1WhenCandidates1Target1", MemberType = typeof(TestDataGenerator))]
        public void CombinationSum2Theory(IList<IList<int>> expected, int[] candidates, int target)
        {
            CombinationSum2ShouldBe(expected, candidates, target);
        }

    }
}
