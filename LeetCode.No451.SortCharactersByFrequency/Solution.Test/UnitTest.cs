using System;
using Xunit;

namespace LeetCode.No451.SortCharactersByFrequency.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void frequencySortShouldBe(string expected, string s)
        {
            Assert.Equal(expected, _solution.FrequencySort(s));
        }

        [Fact]
        public void ExpectedEmptyWhenSisNullOrEmpty()
        {
            string s = "";
            string expected = "";

            frequencySortShouldBe(expected, s);
        }
    }
}
