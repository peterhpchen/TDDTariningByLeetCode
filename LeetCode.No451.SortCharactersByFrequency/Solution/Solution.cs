using System;

namespace LeetCode.No451.SortCharactersByFrequency.Solution
{
    public class Solution
    {
        public string FrequencySort(string s)
        {
            string result = s;
            if (string.IsNullOrEmpty(s)) return result;
            if (s.Length < 3) return result;
            throw new NotImplementedException();
        }
    }
}
