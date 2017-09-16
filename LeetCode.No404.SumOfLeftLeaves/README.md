# LeetCode Problem No 404: Sum of Left Leaves
## Problem
Find the sum of all left leaves in a given binary tree.

**Example:**

> &nbsp;&nbsp;&nbsp;3
> <br>&nbsp;&nbsp;/ \\
> <br>9&nbsp;&nbsp;20
> <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;/ \\
> <br>&nbsp;&nbsp;&nbsp;15  7
>
> There are two left leaves in the binary tree, with values **9** and **15** respectively. Return **24**.

## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No404.SumOfLeftLeaves)

## 解題步驟
1. 如果沒有節點或是只有根節點, 回傳0
```C#
if (root == null) return 0;
if (root.left == null && root.right == null) return 0;
```
2. 使用position參數辨識位置, 迴圈找左葉子
```C#
if (root.left == null) return sumOfLeftLeaves("right", root.right);
if (root.right == null) return sumOfLeftLeaves("left", root.left);
return sumOfLeftLeaves("left", root.left) + sumOfLeftLeaves("right", root.right);
```

3. 如果沒有子節點且position是left, 回傳數值
```C#
if (root.left == null && root.right == null)
{
    if (position == "left") return root.val;
    return 0;
}
```