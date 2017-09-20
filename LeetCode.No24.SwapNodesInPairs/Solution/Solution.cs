using System;

namespace LeetCode.No24.SwapNodesInpairs.Solution
{
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode newHead = head.next;
            newHead.next = head;
            head.next = null;
            return newHead;
        }

    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
