using System;
using Xunit;

namespace LeetCode.No24.SwapNodesInpairs.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void swapPairsShouldBe(ListNode expected, ListNode head)
        {
            ListNode result = _solution.SwapPairs(head);
            do
            {
                Assert.Equal(expected.val, result.val);
                result = result.next;
                expected = expected.next;
            } while (expected.next != null);
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
    }
}
