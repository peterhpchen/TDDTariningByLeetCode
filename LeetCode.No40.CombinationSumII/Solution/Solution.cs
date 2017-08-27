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
            IList<IList<int>> result = new List<IList<int>>();

            foreach (int candidate in candidates)
            {
                if (candidate != target) continue;
                result.Add(new List<int>() { candidate });
            }

            return result.Distinct(new ListComparer<IList<int>>()).ToList();
        }
    }

    public class ListComparer<T> : IEqualityComparer<T>
     where T : IList<int>
    {
        public ListComparer()
        {
            Console.WriteLine("constructor");
        }

        public bool Equals(T x, T y)
        {
            return x.SequenceEquals(y);
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
