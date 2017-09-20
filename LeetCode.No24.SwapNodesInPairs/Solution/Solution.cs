using System;

namespace LeetCode.No24.SwapNodesInpairs.Solution
{
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head.next == null) return head;
            ListNode newHead = head.next;
            ListNode headNext = newHead.next;
            head.next = headNext;
            newHead.next = head;

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
