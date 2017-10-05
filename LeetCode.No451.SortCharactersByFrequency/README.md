# LeetCode Problem No 451: Sort Characters By Frequency
## Problem
Given a string, sort it in decreasing order based on the frequency of characters.

**Example 1:**

>**Input**: "tree"
>
>**Output**: "eert"
>
>**Explanation**: 'e' appears twice while 'r' and 't' both appear once.
So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.

**Example 2:**

>**Input**: "cccaaa"
>
>**Output**: "cccaaa"
>
>**Explanation**: Both 'c' and 'a' appear three times, so "aaaccc" is also a valid answer.
Note that "cacaca" is incorrect, as the same characters must be together.

**Example 3:**

>**Input**: "Aabb"
>
>**Output**: "bbAa"
>
>**Explanation**: "bbaA" is also a valid answer, but "Aabb" is incorrect.
Note that 'A' and 'a' are treated as two different characters.

## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No451.SortCharactersByFrequency)

## Steps
1. return the string of s when it is null or empty or the length is less than 3.
```C#
if (string.IsNullOrEmpty(s)) return result;
if (s.Length < 3) return result;
```

2. Create a Dictionary(key: char of s, value: count of char) to store count of char of s.
```C#
foreach (char c in s)
{
    if (freqDic.ContainsKey(c))
    {
        freqDic[c]++;
        continue;
    }

    freqDic.Add(c, 1);
}
```

3. the dictionary order by count for descending.
```C#
var freqDicList = freqDic.ToList().OrderByDescending(x => x.Value);
```
4. Concat chars in dictionary
```C#
result = string.Concat(freqDicList.Select(x => new string(x.Key, x.Value)));
```