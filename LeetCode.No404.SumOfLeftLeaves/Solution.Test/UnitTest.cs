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
        public void Expected0WhenTreeOnlyHaveRootNode()
        {
            TreeNode root = new TreeNode(0);
            sumOfLeftLeavesShouldBe(0, root);
        }

        [Fact]
        public void Expected0WhenTreeOnlyHaveRightNode()
        {
            TreeNode root = new TreeNode(1);
            TreeNode right = new TreeNode(2);
            root.right = right;

            sumOfLeftLeavesShouldBe(0, root);
        }

        [Fact]
        public void ExpectedSumOfLeftNodeValWhenHaveLeftNode()
        {
            TreeNode root = new TreeNode(3);
            TreeNode left1 = new TreeNode(9);
            TreeNode right1 = new TreeNode(20);
            TreeNode left2 = new TreeNode(15);
            TreeNode right2 = new TreeNode(7);
            TreeNode left3 = new TreeNode(15);
            TreeNode right3 = new TreeNode(7);

            right1.left = left2;
            right1.right = right2;
            left1.left = left3;
            left1.right = right3;
            root.left = left1;
            root.right = right1;

            sumOfLeftLeavesShouldBe(30, root);
        }
    }
}
