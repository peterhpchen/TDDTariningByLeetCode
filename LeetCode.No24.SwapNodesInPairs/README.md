# LeetCode Problem No 24: Swap Nodes in Pairs
## Problem
 Given a linked list, swap every two adjacent nodes and return its head.

For example,
Given `1->2->3->4`, you should return the list as `2->1->4->3`.

Your algorithm should use only constant space. You may **not** modify the values in the list, only nodes itself can be changed. 

## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No24.SwapNodesInPairs)

## 解題步驟
1. 此節點是空或是最後一個停止遞迴, 因為沒得換所以head不會變, 回傳自己
```C#
if (head == null) return head;
if (head.next == null) return head;
```
以下步驟以`1->2->3->4`為例, 在swap後會變為`2->1->4->3`, 每一遞迴以兩個節點觀察

2. 在`1->2`swap後, 新的Head會是2, 也就是原本head(1).next的位置
```C#
ListNode newHead = head.next;
```

3. 原本的頭(1)會變為此次遞迴的最後一個節點, 最後一個節點的下一個就會是下一輪的頭(`3->4`Swap後的結果)
```C#
ListNode headNext = SwapPairs(newHead.next);
```

4. 取得個節點的結果後放到正確的位置, 回傳新的Head即得結果
```C#
head.next = headNext;
newHead.next = head;

return newHead;
```