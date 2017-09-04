using System;
using System.Linq;

namespace LeetCode.No242.ValidAnagram.Solution
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            string sortS = new string (s.OrderBy(x => x).ToArray());
            string sortT = new string (t.OrderBy(x => x).ToArray());
            if (sortS.Equals(sortT)) return true;
            return false;
        }
    }
}
