# LeetCode Problem No 540: Single Element in a Sorted Array
## Problem
Given a sorted array consisting of only integers where every element appears twice except for one element which appears once. Find this single element that appears only once. 

**Example 1:**

> **Input:** [1, 1, 2, 3, 3, 4, 4, 8, 8]
>
> **Output:** 2


**Example 1:**

> **Input:** [3, 3, 7, 7, 10, 11, 11]
>
> **Output:** 10

**Note:** Your solution should run in O(log n) time and O(1) space. 

## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No540.SingleElementInASortedArray)

## 解題步驟
1. nums是Null或是空陣列則回傳0
```C#
if (nums == null || length == 0) return 0;
```
2. nums長度是1的話直接回傳此數字
```C#
if (length == 1) return nums[0];
```

3. 採用遞迴切小陣列來取得答案, 以陣列中心分為左右兩邊, 由以下判斷決定下階段所要拿的子陣列
* 如果子陣列是偶數的話
    * 如果中心的數字不等於中心左右兩邊的話, 答案就是中心數字
    * 如果中心的數字等於左邊的話, 子陣列為左邊
    * 如果中心的數字等於右邊的話, 子陣列為右邊
```C#
if (centerIndex % 2 == 0)
{
    if (currentNum != previousNum && currentNum != afterNum) return currentNum;

    if (currentNum == previousNum) Array.Copy(nums, nextNums, lengthOfNextNums);
    if (currentNum == afterNum) Array.Copy(nums, centerIndex + 2, nextNums, 0, lengthOfNextNums);
    return SingleNonDuplicate(nextNums);
}
```
* 如果子陣列是基數的話
    * 如果中心的數字等於左邊的話, 子陣列為右邊
    * 如果中心的數字等於右邊的話, 子陣列為左邊
```C#
if (currentNum == previousNum) Array.Copy(nums, centerIndex + 1, nextNums, 0, lengthOfNextNums);
if (currentNum == afterNum) Array.Copy(nums, nextNums, lengthOfNextNums);
return SingleNonDuplicate(nextNums);
```