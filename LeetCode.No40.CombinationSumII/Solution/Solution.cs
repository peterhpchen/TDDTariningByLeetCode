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
            resultList = combine(new List<int>(), candidates, target);
            return resultList.Distinct(new ListComparer()).OrderBy(x => x, new ListComp()).ToList();
        }

        private IList<IList<int>> combine(List<int> current, int[] candidates, int target)
        {
            List<IList<int>> resultList = new List<IList<int>>();
            int currentTarget = target;
            int candidate = candidates.First();
            int[] nextCandidates = candidates.Where((val, idx) => idx != 0).ToArray();
            int nextTarget = target - candidate;

            if (nextTarget == 0)
            {
                IList<int> result = current.ToList();
                result.Add(candidate);
                resultList.Add(result);
                return resultList;
            }

            if (nextCandidates.Length == 0) return resultList;
            if (target < nextCandidates[0]) return resultList;
            if (nextTarget < 0) return resultList;

            IList<IList<int>> targetResultList = combine(current, nextCandidates, target);
            if (targetResultList != null) resultList.AddRange(targetResultList);

            List<int> nextCurrent = current.ToList();
            nextCurrent.Add(candidate);
            IList<IList<int>> nextTargetResultList = combine(nextCurrent, nextCandidates, nextTarget);
            if (nextTargetResultList != null) resultList.AddRange(nextTargetResultList);

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
