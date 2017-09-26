using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.No61.RotateList.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void RotateRightShouldBe(ListNode expected, ListNode head, int k)
        {
            ListNode result = _solution.RotateRight(head, k);
            ListNodeComparer listNodeComparer = new ListNodeComparer();
            Assert.Equal(expected, result, listNodeComparer);
        }

        [Fact]
        public void ExpectedHeadIsTheLastNodeWhenKIs1()
        {
            //Given
            ListNode expected = new ListNode(5);
            expected.next = new ListNode(1);
            expected.next.next = new ListNode(2);
            expected.next.next.next = new ListNode(3);
            expected.next.next.next.next = new ListNode(4);

            ListNode head = getListNodeByLength(5);
            int k = 1;

            //When
            RotateRightShouldBe(expected, head, k);
        }

        [Fact]
        public void ExpectedSameWhenKIsZero()
        {
            //Given
            int randomNum = new Random(Guid.NewGuid().GetHashCode()).Next(100);
            ListNode expected = getListNodeByLength(randomNum);
            ListNode head = expected;
            int k = 0;

            //When
            RotateRightShouldBe(expected, head, k);
        }

        [Fact]
        public void ExpectedSameWhenOnlyOneNode()
        {
            //Given
            ListNode expected = new ListNode(1);
            ListNode head = new ListNode(1);
            int k = new Random(Guid.NewGuid().GetHashCode()).Next();

            //When
            RotateRightShouldBe(expected, head, k);
        }

        [Fact]
        public void ExpectedNullWhenListIsNull()
        {
            //Given
            ListNode expected = null;
            ListNode head = null;
            int k = new Random(Guid.NewGuid().GetHashCode()).Next();

            //When
            RotateRightShouldBe(expected, head, k);
        }

        private ListNode getListNodeByLength(int length)
        {
            ListNode head = new ListNode(1);
            ListNode current = head;

            for (int i = 2; i <= length; i++)
            {
                current.next = new ListNode(i);
                current = current.next;
            }

            return head;
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
