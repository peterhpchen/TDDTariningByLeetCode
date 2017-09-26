using System;

namespace LeetCode.No61.RotateList.Solution
{
    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return null;
            if (head.next == null) return head;
            if (k == 0) return head;
            throw new NotImplementedException();
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
