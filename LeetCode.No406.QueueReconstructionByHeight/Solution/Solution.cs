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
        private static int INDEXINSAMEH = 2;
        public int[,] ReconstructQueue(int[,] people)
        {
            int length = people.GetLength(0);
            if (length <= 1) return people;

            int[,] result = new int[length, 2];

            //轉為List
            var peopleList = people.Cast<int>()
                .Select((x, i) => new { x, index = i / 2 })
                .GroupBy(x => x.index)
                .Select(x => x.Select(s => s.x).ToArray());

            //1. 以高度排序
            var orderedPeopleByHeightList = peopleList.OrderBy(x => x[HINDEX]);

            //2. 相同高度的人以k排序, 同時取得目前在相同高度下的位置(i), 在位移時使用
            var orderedPeopleByKList = orderedPeopleByHeightList.GroupBy(x => x[HINDEX])
                .SelectMany(x => x
                    .OrderBy(s => s[KINDEX])
                    .Select((y, i) => y
                        .Concat(new int[] { i })
                        .ToArray()));

            var orderedPeopleList = orderedPeopleByKList.ToList();

            //3. 依照k做位移, 因k包含相同高度的人, 所以要減掉跟此人相同高度且排於前面的人
            for (int i = length - 1; i >= 0; i--)
            {
                int[] person = orderedPeopleList.ElementAt(i);
                int back = person[KINDEX] - person[INDEXINSAMEH];

                if (back == 0) continue;

                orderedPeopleList.Insert(i + back + 1, person);
                orderedPeopleList.RemoveAt(i);
            }

            //轉回int[,]
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
