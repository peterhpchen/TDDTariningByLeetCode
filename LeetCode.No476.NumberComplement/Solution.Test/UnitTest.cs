using System;
using Xunit;

namespace LeetCode.No476.NumberComplement.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void findImplementShouldBe(int num, int respect)
        {
            Assert.Equal(_solution.FindComplement(num), respect);
        }

        [Fact]
        public void Return0WhenNumIs1()
        {
            findImplementShouldBe(1, 0);
        }

        [Fact]
        public void Return1WhenNumIs0()
        {
            findImplementShouldBe(0, 1);
        }
    }
}
