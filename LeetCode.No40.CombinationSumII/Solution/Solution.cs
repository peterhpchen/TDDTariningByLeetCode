using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.No40.CombinationSumII.Solution
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> resultList = new List<IList<int>>();
            candidates = candidates.OrderBy(x => x).ToArray();
            int currentTarget = target;
            int candidate = candidates.First();
            int[] nextCandidates = candidates.Where((val, idx) => idx != 0).ToArray();
            int nextTarget = target - candidate;

            if (nextTarget == 0)
            {
                resultList.Add(new List<int>() { candidate });
                return resultList;
            }

            if(nextCandidates.Length==0)return resultList;

            if (nextTarget > 0)
            {
                IList<IList<int>> nextTargetResultList = CombinationSum2(nextCandidates, nextTarget);
                if (nextTargetResultList != null)
                {
                    foreach (IList<int> nextTargetResult in nextTargetResultList)
                    {
                        List<int> result = new List<int>();
                        result.Add(candidate);
                        result.AddRange(nextTargetResult);
                        resultList.Add(result);
                    }
                }
                IList<IList<int>> targetResultList = CombinationSum2(nextCandidates, target);
                foreach (IList<int> targetResult in targetResultList)
                {
                    resultList.Add(targetResult);
                }

            }
            return resultList.OrderBy(x => x[0]).Distinct(new ListComparer<IList<int>>()).ToList();
        }
    }

    public class ListComparer<T> : IEqualityComparer<T>
     where T : IList<int>
    {
        public bool Equals(T x, T y)
        {
            return x.SequenceEqual(y);
        }

        public int GetHashCode(T obj)
        {
            int hCode = obj[0];
            for (int i = 1; i < obj.Count(); i++)
            {
                hCode = hCode ^ obj[i];
            }
            return hCode.GetHashCode();
        }
    }
}
