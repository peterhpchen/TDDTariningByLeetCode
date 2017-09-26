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
        public void ExpectedNullWhenListIsNull()
        {
            //Given
            ListNode expected = null;
            ListNode head = null;
            int k = new Random(Guid.NewGuid().GetHashCode()).Next();

            //When
            RotateRightShouldBe(expected, head, k);
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
