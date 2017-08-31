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
            return resultList.Distinct(new ListComparer()).OrderBy(x => x, new ListComp()).ToList();
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
            if (nextTarget < 0) return resultList;

            IList<IList<int>> targetResultList = combine(nextCandidates, target);
            if (targetResultList != null) resultList.AddRange(targetResultList);

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

            return resultList;
        }
    }

    public class ListComp : IComparer<IList<int>>
    {
        public int Compare(IList<int> x, IList<int> y)
        {
            int xLength = x.Count();
            int yLength = y.Count();

            int length = xLength > yLength ? yLength : xLength;

            int result = 0;

            for (int i = 0; i < length; i++)
            {
                if (x[i].CompareTo(y[i]) != 0) { result = x[i].CompareTo(y[i]); break; }
            }

            return result;
        }
    }

    public class ListComparer : IEqualityComparer<IList<int>>
    {
        public bool Equals(IList<int> x, IList<int> y)
        {
            return x.SequenceEqual(y);
        }

        public int GetHashCode(IList<int> obj)
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
