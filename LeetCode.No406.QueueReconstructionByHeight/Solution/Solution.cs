using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace LeetCode.No406.QueueReconstructionByHeight.Solution
{
    public class Solution
    {
        private static int HINDEX = 0;
        private static int KINDEX = 1;
        public int[,] ReconstructQueue(int[,] people)
        {
            int length = people.GetLength(0);
            if (length <= 1) return people;

            int[,] result = new int[length, 2];
            var peopleList = people.Cast<int>()
                .Select((x, i) => new { x, index = i / 2 })
                .GroupBy(x => x.index)
                .Select(x => x.Select(s => s.x).ToArray());

            var orderedPeopleList = peopleList.OrderBy(x => x[HINDEX]);

            for (int i = 0; i < length; i++)
            {
                int[] person = orderedPeopleList.ElementAt(i);
                int height = person[HINDEX];
                int number = person[KINDEX];
                result[i, HINDEX] = height;
                result[i, KINDEX] = number;
            }
            return result;
        }
    }
}
