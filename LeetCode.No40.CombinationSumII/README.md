# LeetCode Problem No 40: Combination Sum II
## Problem
Given a collection of candidate numbers (**C**) and a target number (**T**), find all unique combinations in **C** where the candidate numbers sums to **T**.

Each number in **C** may only be used **once** in the combination.

**Note:**
* All numbers (including target) will be positive integers.
* The solution set must not contain duplicate combinations.

For example, given candidate set [10, 1, 2, 7, 6, 1, 5] and target 8,
A solution set is:

[
  [1, 7],
  [1, 2, 5],
  [2, 6],
  [1, 1, 6]
]


## Solution
> [TDD Training Commit Log](https://github.com/peterhpchen/TDDTariningByLeetCode/commits/master/LeetCode.No40.CombinationSumII)

## 解題步驟
1. 排序數列, 減少搜尋次數
```C#
candidates = candidates.OrderBy(x => x).ToArray();
```
2. 以遞迴函數找出符合Target的數列, 每次都抓出數列中的第一個數字跟Target做比對
```C#
int candidate = candidates.First();
int[] nextCandidates = candidates.Where((val, idx) => idx != 0).ToArray();
```
3. 第一跟數字跟Target相減如果為零, 代表此數列已符合Taregt, 回傳
```C#
int nextTarget = target - candidate;

if (nextTarget == 0)
{
    IList<int> result = current.ToList();
    result.Add(candidate);
    resultList.Add(result);
    return resultList;
}
```
4. 下列三種狀況中止遞迴
* 候選數列已空
* 目標數小於下個候選數
* 下個目標數為負數
```C#
if (nextCandidates.Length == 0) return resultList;
if (target < nextCandidates[0]) return resultList;
if (nextTarget < 0) return resultList;
```

5. 開始遞迴, 情況有二
* 本次目標數不在數列中, 以上層的目標數繼續找下次的候選數列
* 本次目標數在數列中, 將本次目標數放進Current數列中傳入下層, 以本層的目標數繼續找下次的候選數列
```C#
IList<IList<int>> targetResultList = combine(current, nextCandidates, target);
if (targetResultList != null) resultList.AddRange(targetResultList);

List<int> nextCurrent = current.ToList();
nextCurrent.Add(candidate);
IList<IList<int>> nextTargetResultList = combine(nextCurrent, nextCandidates, nextTarget);
if (nextTargetResultList != null) resultList.AddRange(nextTargetResultList);
```
## 程式筆記
List\<List\<int>>因為是List of list的結構, 如果不自定義compare會無法OrderBy或是Distinct, 以下筆記為紀錄用自定義方式比對List
### IEqualityComparer\<T>
>定義支援物件之相等比較的方法
    
要繼承此介面要實做兩個method: Equals跟GetHashCode, 以下說明這兩個method的用途: 
#### Equals
>比對兩個數相不相等
此題為了要比對List<int>之間是否相等使用了SequenceEqual
```C#
public bool Equals(IList<int> x, IList<int> y)
{
    return x.SequenceEqual(y);
}
```
此方法會比對兩個序列的元素是否相同, 因兩個不同的List做比對時就算List中的元素相同, 還是會被比對為不同, 所以使用此方法一個一個去比對element是否相同

#### GetHashCode
>取得此物件的雜湊碼
可以把它想成是物件的身份證字號, C#使用此Code判斷兩個物件是否相等
```C#
public int GetHashCode(IList<int> obj)
{
    int hCode = obj[0];
    for (int i = 1; i < obj.Count(); i++)
    {
        hCode = hCode ^ obj[i];
    }
    return hCode.GetHashCode();
}
```
List或是Model會對每個物件做XOR, 再對它取HashCode
>每個HashCode相同的物件不代表兩個物件相等,[參考連結](https://stackoverflow.com/questions/7425142/what-is-hashcode-used-for-is-it-unique)

>當Comparer發現兩個元素的HashCode相等時就會做Equals判斷是否相等, [參考連結](https://stackoverflow.com/a/371348/3493127)