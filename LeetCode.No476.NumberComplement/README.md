# LeetCode Problem No 476: Number Complement
## Problem
Given a positive integer, output its complement number. The complement strategy is to flip the bits of its binary representation.

**Note:**

> 1. The given integer is guaranteed to fit within the range of a 32-bit signed integer.
> 2. You could assume no leading zero bit in the integer’s binary representation.

**Example 1:**

> **Input:** 5
>
> **Output:** 2
>
> **Explanation:** The binary representation of 5 is 101 (no leading zero bits), and its complement is 010. So you need to output 2.

**Example 2:**

> **Input:** 1
> 
> **Output:** 0
>
> **Explanation:** The binary representation of 1 is 1 (no leading zero bits), and its complement is 0. So you need to output 0.

## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No476.NumberComplement)

## 解題步驟
1. 計算2進位制長度
```C#
int binaryLength = Convert.ToString(num, 2).Length;
```
2. 以步驟1取得的長度為次方的最大正數
```C#
int all1BinaryNum = (int)Math.Pow(2, binaryLength) - 1;
```

3. 跟參數num做xor運算得到結果
```C#
return num ^ all1BinaryNum;
```