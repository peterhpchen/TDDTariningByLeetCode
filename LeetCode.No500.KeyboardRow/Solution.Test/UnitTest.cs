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
    }
}
