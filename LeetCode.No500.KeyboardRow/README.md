# LeetCode Problem No 500: Keyboard Row
## Problem
Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.

![image of keyboard](https://leetcode.com/static/images/problemset/keyboard.png)

**Example 1:**

> **Input:** ["Hello", "Alaska", "Dad", "Peace"]
>
> **Output:** ["Alaska", "Dad"]

**Note:**

1. You may use one character in the keyboard more than once.
2. You may assume the input string will only contain letters of alphabet.

## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No500.KeyboardRow)

## 解題步驟
1. 問題拆解至判斷各個字串是否為Word
```C#
return words.Where(x => isWord(x)).ToArray();
```
2. 長度為一或是空字串時一定是Word
```C#
if (word.Length < 2) return true;
```

3. 建立各個row的group做比對
```C#
private string[] rowGroup = { "ASDFGHJKL", "QWERTYUIOP", "ZXCVBNM" };
```
4. 兩個迴圈, 外圈跑每個字元, 內圈跑group array
```C#
for (int i = 0; i < word.Length; i++)
{
    char letter = word[i];
    for (int j = 0; j < rowGroup.Length; j++)
    {
```

5. 第一個字元拿到的group index當作基準, 跟基準不同代表不是word
```C#
if (i == 0)
{
    currentGroup = j;
    break;
}
if (currentGroup != j) return false;
```
6. 所有字元轉大寫, 以通過大小寫混雜之案例
```C#
if (rowGroup[j].IndexOf(char.ToUpper(letter)) > -1)
```