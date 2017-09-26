﻿using System;
using System.Collections.Generic;

namespace LeetCode.No61.RotateList.Solution
{
    public class Solution
    {

        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return null;
            if (k == 0) return head;
            if (head.next == null) return head;

            Stack<ListNode> nodes = new Stack<ListNode>();
            ListNode current = head;
            ListNode result = null;

            do
            {
                nodes.Push(current);
                ListNode currentNext = current.next;
                if (currentNext == null)
                {
                    result = nodes.Pop();
                    result.next = head;
                    nodes.Pop().next = null;
                    break;
                }
                current = current.next;
            } while (current != null);
            
            return result;;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
