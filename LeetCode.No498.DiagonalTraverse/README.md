# LeetCode Problem No 498: Diagonal Traverse
## Problem
Given a matrix of M x N elements (M rows, N columns), return all elements of the matrix in diagonal order as shown in the below image.

**Example:**

>**Input**: 
> <br>[
> <br>&nbsp;[ 1, 2, 3 ],
> <br>&nbsp;[ 4, 5, 6 ],
> <br>&nbsp;[ 7, 8, 9 ]
> <br>]
>
>**Output**: [1,2,4,7,5,3,6,8,9]
>
>**Explanation**: 
> <br>![diagonal_traverse](https://leetcode.com/static/images/problemset/diagonal_traverse.png)

**Note:**

1. The total number of elements of the given matrix will not exceed 10,000.

## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No498.DiagonalTraverse)

## Steps
1. If the count of the element of matrix is zero, it would return empty array.
```C#
if (allElementCount == 0) return new int[] { };
```

2. It would return the array which converted to the single dimension, if it is a array which is the single row or the single column.
```C#
if (matrix.GetLength((int)array2D.row) == 1)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        result[i] = matrix[0, i];
    }
    return result;
}

if (matrix.GetLength((int)array2D.col) == 1)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        result[i] = matrix[i, 0];
    }
    return result;
}
```

3. Diagonal Traverse
* `First step`: turn `right`
```C#
if (rowMove == 0 && colMove == 0)
{
    rowMove = 0;
    colMove = 1;
    continue;
}
```

* Previous step is turn `right`: 

    * If the current row is the `first row`: turn `left down`
    * If the current row is the `last row`: turn `right up`
```C#
if (rowMove == 0 && colMove == 1)
{
    if (currentRow == 0)
    {
        rowMove = 1;
        colMove = -1;
        continue;
    }
    rowMove = -1;
    colMove = 1;
    continue;
}
```

* Previous step is turn `left down`:

    * If the current row is the `last row`: turn `right`
    * If the current column is the `first column`: turn `down`
    * If the condition which exclude above: continually turn `left down`
```C#
if (rowMove == 1 && colMove == -1)
{
    if (currentRow == rowMaxIndex)
    {
        rowMove = 0;
        colMove = 1;
        continue;
    }

    if (currentCol == 0)
    {
        rowMove = 1;
        colMove = 0;
        continue;
    }
}
```

* Previous step is turn `down`:

    * If the current column is the `last column`: turn `left down`
    * If the current column is the `first column`: turn `right up`
```C#
if (rowMove == 1 && colMove == 0)
{
    if (currentCol == colMaxIndex)
    {
        rowMove = 1;
        colMove = -1;
        continue;
    }
    rowMove = -1;
    colMove = 1;
    continue;
}
```

* Previous step is turn `right up`:

    * If the current column is the `last column`: turn `down`
    * If the current row is the `first row`: turn `right`
    * If the condition which exclude above: continually turn `right up`
```C#
if (rowMove == -1 && colMove == 1)
{
    if (currentCol == colMaxIndex)
    {
        rowMove = 1;
        colMove = 0;
        continue;
    }
    if (currentRow == 0)
    {
        rowMove = 0;
        colMove = 1;
        continue;
    }
}
```