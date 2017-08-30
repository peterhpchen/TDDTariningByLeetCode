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
            yield return new object[] { new List<IList<int>>() { new List<int>() { 1 } }, new int[] { 1, 1 }, 1 };
            yield return new object[] { new List<IList<int>>() { new List<int>() { 1, 1 } }, new int[] { 1, 1 }, 2 };
            yield return new object[] { new List<IList<int>>() { new List<int>() { 1 } }, new int[] { 1, 2 }, 1 };
            yield return new object[] { new List<IList<int>>() { new List<int>() { 2 } }, new int[] { 1, 2 }, 2 };
            yield return new object[] { new List<IList<int>>() { new List<int>() { 1, 2 }, new List<int>() { 3 } }, new int[] { 3, 1, 2 }, 3 };
            yield return new object[] { new List<IList<int>>() { new List<int>() { 1, 1, 1 }, new List<int>() { 1, 2 }, new List<int>() { 3 } }, new int[] { 3, 1, 2, 1, 1 }, 3 };
            yield return new object[] { new List<IList<int>>() { new List<int>() { 1, 1, 6 }, new List<int>() { 1, 2, 5 }, new List<int>() { 1, 7 }, new List<int>() { 2, 6 } }, new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8 };
            yield return new object[] { new List<IList<int>>() {
                new List<int>() { 5,7,7,8 },
                new List<int>() { 5,7,15 },
                new List<int>() { 5,8,14 },
                new List<int>() { 5,10,12 },
                new List<int>() { 5,11,11 },
                new List<int>() { 5,22 },
                new List<int>() { 7,8,12 },
                new List<int>() { 7,9,11 },
                new List<int>() { 7,10,10 },
                new List<int>() { 8,9,10 },
                new List<int>() { 8,19 },
                new List<int>() { 9,18 },
                new List<int>() { 10,17 },
                new List<int>() { 11,16 },
                new List<int>() { 12,15 },
                new List<int>() { 27 } }, new int[] { 14, 10, 29, 11, 8, 27, 28, 30, 16, 23, 33, 33, 7, 34, 14, 23, 17, 28, 10, 29, 9, 15, 17, 32, 34, 22, 7, 22, 12, 18, 10, 21, 24, 26, 19, 27, 18, 12, 14, 29, 22, 12, 27, 16, 11, 28, 5, 16, 22, 10, 32, 18, 21, 7, 15 }, 27 };
        }
    }

    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void CombinationSum2ShouldBe(IList<IList<int>> expected, int[] candidates, int target)
        {
            var result = _solution.CombinationSum2(candidates, target);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData("Expected1WhenCandidates1Target1", MemberType = typeof(TestDataGenerator))]
        public void CombinationSum2Theory(IList<IList<int>> expected, int[] candidates, int target)
        {
            CombinationSum2ShouldBe(expected, candidates, target);
        }

    }
}
