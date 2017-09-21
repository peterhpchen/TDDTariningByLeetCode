using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.No24.SwapNodesInpairs.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void swapPairsShouldBe(ListNode expected, ListNode head)
        {
            ListNode result = _solution.SwapPairs(head);
            ListNodeComparer listNodeComparer = new ListNodeComparer();
            Assert.Equal(expected, result, listNodeComparer);
        }

        [Fact]
        public void expectedSameWhenLengthOfListIs1()
        {
            //When
            ListNode head = new ListNode(1);
            ListNode expected = new ListNode(1);

            //Then
            swapPairsShouldBe(expected, head);
        }

        [Fact]
        public void expectedReverseWhenLengthOfListIsTwo()
        {
            //When
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            ListNode expected = new ListNode(2);
            expected.next = new ListNode(1);

            //Then
            swapPairsShouldBe(expected, head);
        }

        [Fact]
        public void expectedReverse1and2NodeWhenLengthOfListIs3()
        {
            //When
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            ListNode expected = new ListNode(2);
            expected.next = new ListNode(1);
            expected.next.next = new ListNode(3);

            //Then
            swapPairsShouldBe(expected, head);
        }

        [Fact]
        public void expectedSwitchPairNodesWhenLengthOfListIsEven()
        {
            //When
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            ListNode expected = new ListNode(2);
            expected.next = new ListNode(1);
            expected.next.next = new ListNode(4);
            expected.next.next.next = new ListNode(3);

            //Then
            swapPairsShouldBe(expected, head);
        }
        
        [Fact]
        public void expectedSwitchPairExceptTheLastNodeWhenLengthOfListIsOdd()
        {
            //When
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            ListNode expected = new ListNode(2);
            expected.next = new ListNode(1);
            expected.next.next = new ListNode(4);
            expected.next.next.next = new ListNode(3);
            expected.next.next.next.next = new ListNode(5);

            //Then
            swapPairsShouldBe(expected, head);
        }
    }

    public class ListNodeComparer : IEqualityComparer<ListNode>
    {
        public bool Equals(ListNode listNode1, ListNode listNode2)
        {
            if (listNode1 == null && listNode2 == null) return true;
            if (listNode1 == null || listNode2 == null) return false;

            do
            {
                if (listNode1 == null) return false;
                if (listNode2 == null) return false;
                if (!listNode1.val.Equals(listNode2.val)) return false;
                listNode1 = listNode1.next;
                listNode2 = listNode2.next;
            } while (listNode1 != null || listNode2 != null);

            return true;
        }

        public int GetHashCode(ListNode listNode)
        {
            int hCode = 0;

            do
            {
                hCode ^= listNode.val;
                listNode = listNode.next;
            } while (listNode != null);

            return hCode;
        }
    }
}
