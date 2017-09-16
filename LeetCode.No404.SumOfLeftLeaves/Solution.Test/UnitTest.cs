using System;
using Xunit;

namespace LeetCode.No404.SumOfLeftLeaves.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();
        private void sumOfLeftLeavesShouldBe(int expected, TreeNode root)
        {
            Assert.Equal(expected, _solution.SumOfLeftLeaves(root));
        }

        [Fact]
        public void expected0WhenTreeOnlyHaveRootNode()
        {
           TreeNode root = new TreeNode(0);
           sumOfLeftLeavesShouldBe(0, root);
        }
    }
}
