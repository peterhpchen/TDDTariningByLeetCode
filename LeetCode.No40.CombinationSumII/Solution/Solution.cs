using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.No40.CombinationSumII.Solution
{
    public class Solution
    {
        private List<string> identityList = new List<string>();
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> resultList = new List<IList<int>>();
            candidates = candidates.OrderBy(x => x).ToArray();
            resultList = combine(candidates, target);
            return resultList.Distinct(new ListComparer<IList<int>>()).ToList();
        }

        private IList<IList<int>> combine(int[] candidates, int target)
        {
            List<IList<int>> resultList = new List<IList<int>>();
            int currentTarget = target;
            int candidate = candidates.First();
            int[] nextCandidates = candidates.Where((val, idx) => idx != 0).ToArray();
            int nextTarget = target - candidate;

            if (nextTarget == 0)
            {
                resultList.Add(new List<int>() { candidate });
                return resultList;
            }

            if (nextCandidates.Length == 0) return resultList;
            if (target < nextCandidates[0]) return resultList;

            if (nextTarget > 0)
            {

                IList<IList<int>> nextTargetResultList = combine(nextCandidates, nextTarget);
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
                IList<IList<int>> targetResultList = combine(nextCandidates, target);
                if (targetResultList != null)
                {
                    resultList.AddRange(targetResultList);
                }

            }
            return resultList;
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
