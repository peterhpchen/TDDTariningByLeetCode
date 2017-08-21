using System;
using Xunit;

namespace LeetCode.No476.NumberComplement.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void findImplementShouldBe(int expect, int num)
        {
            Assert.Equal(expect, _solution.FindComplement(num));
        }

        [Fact]
        public void Expect0WhenNumIs1()
        {
            findImplementShouldBe(0, 1);
        }

        [Fact]
        public void Expect1WhenNumIs0()
        {
            findImplementShouldBe(1, 0);
        }

        [Fact]
        public void Expect2WhenNumIs5()
        {
            findImplementShouldBe(2, 5);
        }
    }
}
