using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(string[] id_list, string[] report, int k)
    {
        int[] answer = new int[id_list.Length];
        Dictionary<string, List<string>> reportDict = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> banDict = new Dictionary<string, List<string>>();
        Dictionary<string, int> mailCount = new Dictionary<string, int>();

        report = report.Distinct().ToArray();

        foreach (string r in report)
        {
            var s = r.Split(' ');
            if (!reportDict.TryAdd(s[0], new List<string>(new string[] { s[1] })))
                reportDict[s[0]].Add(s[1]);
            if (!banDict.TryAdd(s[1], new List<string>(new string[] { s[0] })))
                banDict[s[1]].Add(s[0]);
        }

        foreach (var e in banDict)
            if (e.Value.Count >= k)
                foreach (var id in e.Value)
                    if (!mailCount.TryAdd(id, 1))
                        mailCount[id]++;

        for (int i = 0; i < id_list.Length; i++)
            if (mailCount.TryGetValue(id_list[i], out var count))
                answer[i] = count;

        return answer;
    }
}