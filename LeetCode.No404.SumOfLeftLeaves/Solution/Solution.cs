using System;

namespace LeetCode.No404.SumOfLeftLeaves.Solution
{
    public class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root.left == null && root.right == null) return 0;
            throw new NotImplementedException();
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
