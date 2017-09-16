using System;

namespace LeetCode.No404.SumOfLeftLeaves.Solution
{
    public class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return 0;
            if (root.left == null) return sumOfLeftLeaves("right", root.right);
            if (root.right == null) return sumOfLeftLeaves("left", root.left);
            return sumOfLeftLeaves("left", root.left) + sumOfLeftLeaves("right", root.right);
        }

        private int sumOfLeftLeaves(string position, TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null)
            {
                if (position == "left") return root.val;
                return 0;
            }
            if (root.left == null) return sumOfLeftLeaves("right", root.right);
            if (root.right == null) return sumOfLeftLeaves("left", root.left);
            return sumOfLeftLeaves("left", root.left) + sumOfLeftLeaves("right", root.right);
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
