﻿using System;
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
            IList<int> result = new List<int>();

            foreach (int candidate in candidates)
            {
                if (candidate != target)
                {
                    if (target >= candidate)
                    {
                        result.Add(candidate);
                        target = target - candidate;
                    }
                    continue;
                }
                result.Add(candidate);
            }
            resultList.Add(result);

            return resultList.Distinct(new ListComparer<IList<int>>()).ToList();
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
