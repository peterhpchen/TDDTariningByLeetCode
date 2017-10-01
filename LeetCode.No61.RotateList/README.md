# LeetCode Problem No 61: Rotate List
## Problem
Given a list, rotate the list to the right by k places, where k is non-negative.

For example:
Given `1->2->3->4->5->NULL` and k = `2`,
return `4->5->1->2->3->NULL`.

## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No61.RotateList)

## 解題步驟
1. If it is a situation which don't need rotate list, it would do nothing.
```C#
if (head == null) return null;
if (k == 0) return head;
if (head.next == null) return head;
```
2. Create a Stack object for recording nodes.
```C#
Stack<ListNode> nodes = new Stack<ListNode>();
```

3. Traverse every list node to push node into stack
```C#
do
{
    ...
    nodes.Push(current);

    ListNode currentNext = current.next;
    ...
    current = currentNext;
} while (current != null);
```

4. If the next node is null, the stack would pop k nodes to find the head of result. The previous node of result is end node. Now, we find the head and end node.
```C#
for (int i = 0; i < k; i++)
{
    nodes.Pop();
}
ListNode end = nodes.Pop();
result = end.next;
```

5. The next node of the current links to current head.
```C#
current.next = head;
```

6. the end node of the next of the result links to null.
```C#
end.next = null;
```

7. The number of k divided by the length of the list node. The remainder is the rotated number.
```C#
k = k % length;
if (k == 0) break;
```