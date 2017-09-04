using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode.No242.ValidAnagram.Solution
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (!s.Length.Equals(t.Length)) return false;
            return isAnagram(s, t);
        }

        private bool isAnagram(string s, string t)
        {
            List<char> sList = s.ToList<char>();
            foreach (char tChar in t)
            {
                int charIndex = sList.IndexOf(tChar);
                if (charIndex == -1) return false;
                sList.RemoveAt(charIndex);
            }
            return true;
        }
    }
}