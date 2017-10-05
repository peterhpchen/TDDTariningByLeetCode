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
        public void Expected_b_b_a_WhenSIs_a_b_b()
        {
            string s = "abb";
            string expected = "bba";

            frequencySortShouldBe(expected, s);
        }

        [Fact]
        public void ExpectedTheSameStringWhenTheLengthOfSIsLessThan3()
        {
            string s = "ab";
            string expected = "ab";

            frequencySortShouldBe(expected, s);
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
