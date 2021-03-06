using System;
using Xunit;

namespace LeetCode.No500.KeyboardRow.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void findWordsShouldBe(string[] expect, string[] words)
        {
            Assert.Equal(expect, _solution.FindWords(words));
        }

        [Theory]
        [InlineData(new string[] { "A" }, new string[] { "A" })]
        [InlineData(new string[] { "A", "B" }, new string[] { "A", "B" })]
        [InlineData(new string[] { }, new string[] { "AZ" })]
        [InlineData(new string[] { "AS" }, new string[] { "AS" })]
        [InlineData(new string[] { "AA" }, new string[] { "AA" })]
        [InlineData(new string[] { }, new string[] { "Az" })]
        [InlineData(new string[] { "Alaska", "Dad" }, new string[] { "Hello", "Alaska", "Dad", "Peace" })]
        public void FindWordsTheory(string[] expect, string[] words)
        {
            findWordsShouldBe(expect, words);
        }
    }
}
