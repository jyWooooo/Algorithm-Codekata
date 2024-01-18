using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] fees, string[] records)
    {
        List<int> answer = new List<int>();
        SortedDictionary<string, List<TimeSpan>> dict = new SortedDictionary<string, List<TimeSpan>>();

        foreach (string record in records)
        {
            var splits = record.Split(' ');
            var span = TimeSpan.Parse(splits[0]);
            var carNumber = splits[1];
            if (!dict.TryAdd(carNumber, new List<TimeSpan>{ span }))
                dict[carNumber].Add(span);
        }

        foreach (var list in dict.Values)
        {
            if (list.Count % 2 != 0)
                list.Add(new TimeSpan(23, 59, 00));

            var span = TimeSpan.Zero;
            for (int i = 0; i < list.Count; i += 2)
                span += list[i + 1] - list[i];
            int unitTime = (int)MathF.Ceiling(((float)span.TotalMinutes - fees[0]) / fees[2]);
            answer.Add(fees[1] + (unitTime > 0 ? unitTime * fees[3] : 0));
        }
        return answer.ToArray();
    }
}