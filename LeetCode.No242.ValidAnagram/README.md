# LeetCode Problem No 242: Valid Anagram
## Problem
Given two strings s and t, write a function to determine if t is an anagram of s.

For example,

s = "anagram", t = "nagaram", return true.

s = "rat", t = "car", return false.

**Note:**
You may assume the string contains only lowercase alphabets.

**Follow up:**
What if the inputs contain unicode characters? How would you adapt your solution to such case?

## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No242.ValidAnagram)

## 解題步驟
1. 判斷長度是否相同, 不相同回傳false
2. 相同則對兩字串做排序
3. 比對兩字串相同則true, 否則false