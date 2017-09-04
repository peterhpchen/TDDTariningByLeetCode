using System;
using Xunit;

namespace LeetCode.No242.ValidAnagram.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void isAnagramShouldBe(bool expected, string s, string t)
        {
            Assert.Equal(expected, _solution.IsAnagram(s, t));
        }

        [Fact]
        public void ExpectedTrueWhenStringEquals()
        {
            string sameString = "same";
            isAnagramShouldBe(true, sameString, sameString);
        }
    }
}
