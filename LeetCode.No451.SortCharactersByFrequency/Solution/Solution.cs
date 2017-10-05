using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.No451.SortCharactersByFrequency.Solution
{
    public class Solution
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> freqDic = new Dictionary<char, int>();

            string result = s;
            if (string.IsNullOrEmpty(s)) return result;
            if (s.Length < 3) return result;

            foreach (char c in s)
            {
                if (freqDic.ContainsKey(c))
                {
                    freqDic[c]++;
                    continue;
                }

                freqDic.Add(c, 1);
            }
            var freqDicList = freqDic.ToList().OrderByDescending(x => x.Value);
            result = string.Concat(freqDicList.Select(x => new string(x.Key, x.Value)));

            return result;
        }
    }
}
