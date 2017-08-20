using System;
using Xunit;

namespace LeetCode.No476.NumberComplement.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void FindImplementShouldBe(int num, int respect)
        {
            Assert.Equal(_solution.FindComplement(num), respect);
        }
    }
}
