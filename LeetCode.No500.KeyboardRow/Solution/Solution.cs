using System;
using System.Linq;

namespace LeetCode.No500.KeyboardRow.Solution
{
    public class Solution
    {
        private string[] rowGroup = { "ASDFGHJKL", "QWERTYUIOP", "ZXCVBNM" };

        public string[] FindWords(string[] words)
        {
            return words.Where(x => isWord(x)).ToArray();
        }

        private bool isWord(string word)
        {
            if (word.Length < 2) return true;
            int currentGroup = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                for (int j = 0; j < rowGroup.Length; j++)
                {
                    if (rowGroup[j].IndexOf(char.ToUpper(letter)) > -1)
                    {
                        if (i == 0)
                        {
                            currentGroup = j;
                            break;
                        }
                        if (currentGroup != j) return false;
                    }
                }
            }
            return true;
        }
    }
}
