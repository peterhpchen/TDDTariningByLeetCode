using System;

namespace LeetCode.No242.ValidAnagram.Solution
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Equals(t)) return true;
            return false;
        }
    }
}
