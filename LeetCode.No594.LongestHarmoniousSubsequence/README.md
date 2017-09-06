# LeetCode Problem No 594: Longest Harmonious Subsequence
## Problem
We define a harmonious array is an array where the difference between its maximum value and its minimum value is **exactly** 1.

Now, given an integer array, you need to find the length of its longest harmonious subsequence among all its possible subsequences.

**Example 1:**

>**Input**: [1,3,2,2,5,2,3,7]
>
>**Output**: 5
>
>**Explanation**: The longest harmonious subsequence is [3,2,2,2,3].

**Note:** The length of the input array will not exceed 20,000.

## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No594.LongestHarmoniousSubsequence)

## 解題步驟
1. 長度小於或等於一的數列LHS長度為零

2. 對數列做排序

3. 計算出index＝0的第一個數, 將數字跟計數都記起來
```C#
int i = 0;
int currentNum = sortNums.ElementAt(i);
numCount = sortNums.Count(x => x == currentNum);
```
4. 開始跑迴圈

5. 因目前數已經做好計算, 故從陣列中刪除
```C#
sortNums.RemoveRange(0, numCount);
sortNumsCount -= numCount;
```
6. 下個數的計數因為已經做排序所以遇到不同的數就跳出
```C#
int nextNumCount = 0;
foreach (int sortNum in sortNums)
{
    if (nextNum != sortNum) break;
    nextNumCount++;
}
```

7. 如果目前跟下個數的差值為一, 則互加看是否比現在的候選值還大
```C#
if (nextNum - currentNum == 1)
{
    int HS = numCount + nextNumCount;
    if (HS > LengthOfLHS) LengthOfLHS = HS;
}
```

8. 將目前數以下次數置換, 進行下一輪查找
```C#
currentNum = nextNum;
numCount = nextNumCount;
```