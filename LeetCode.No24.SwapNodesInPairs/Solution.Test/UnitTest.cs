using System;
using Xunit;

namespace LeetCode.No24.SwapNodesInpairs.Solution.Test
{
    public class UnitTest
    {
        private Solution _solution = new Solution();

        private void swapPairsShouldBe(ListNode expected, ListNode head)
        {
            Assert.Equal(expected, _solution.SwapPairs(head));
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
