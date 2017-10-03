# LeetCode Problem No 645: Set Mismatch
## Problem
The set `S` originally contains numbers from 1 to `n`. But unfortunately, due to the data error, one of the numbers in the set got duplicated to another number in the set, which results in repetition of one number and loss of another number.

Given an array `nums` representing the data status of this set after the error. Your task is to firstly find the number occurs twice and then find the number that is missing. Return them in the form of an array. 

**Example 1:**

>**Input**: nums = [1,2,2,4]
>
>**Output**: [2,3] 

**Note:**
1. The given array size will in the range [2, 10000].
1. The given array's numbers won't have any order.

## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No645.SetMismatch)

## Steps
1. It would return empty array, if the nums of length less than 1.
```C#
if (length < 2) return new int[] { };
```

2. Create a check array and store the num in the specify index. If the num is already stored, then it is the duplicate num.
```C#
foreach (int num in nums)
{
    int index = num - 1;
    if (checkArray[index] == 0)
    {
        checkArray[index] = num;
        continue;
    }
    result[0] = num;
}
```

3. Get the loss num in the check array.
> If the index of the check array is not zero, it the loss num.
```C#
for (int i = 0; i < checkArray.Length; i++)
{
    if (checkArray[i] != 0) continue;
    result[1] = i + 1;
    break;
}
```