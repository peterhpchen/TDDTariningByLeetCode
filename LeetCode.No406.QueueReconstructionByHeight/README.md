# LeetCode Problem No 406: Queue Reconstruction by Height 
## Problem
Suppose you have a random list of people standing in a queue. Each person is described by a pair of integers `(h, k)`, where `h` is the height of the person and `k` is the number of people in front of this person who have a height greater than or equal to `h`. Write an algorithm to reconstruct the queue.

**Note:**

The number of people is less than 1,100.

**Example 1:**

>**Input**: <br>[[7,0], [4,4], [7,1], [5,0], [6,1], [5,2]]
>
>**Output**: <br>[[5,0], [7,0], [5,2], [6,1], [4,4], [7,1]]

## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No406.QueueReconstructionByHeight)

## Steps
1. If the length of people less than 2, it would return itself.
```C#
int length = people.GetLength(0);
if (length <= 1) return people;
```

2. People is ordered by Height.
```C#
var orderedPeopleByHeightList = peopleList.OrderBy(x => x[HINDEX]);
```

3. People in the same height is ordered by k.
```C#
var orderedPeopleByKList = orderedPeopleByHeightList.GroupBy(x => x[HINDEX])
    .SelectMany(x => x
        .OrderBy(s => s[KINDEX])
        .Select((y, i) => y
            .Concat(new int[] { i })
            .ToArray()));
```

4. Person would back (k - index in the same height) position in the array of people.
```C#
for (int i = length - 1; i >= 0; i--)
{
    int[] person = orderedPeopleList.ElementAt(i);
    int back = person[KINDEX] - person[INDEXINSAMEH];

    if (back == 0) continue;

    orderedPeopleList.Insert(i + back + 1, person);
    orderedPeopleList.RemoveAt(i);
}
```