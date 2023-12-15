using System;
using System.Collections.Generic;

public class Solution
{
    public int DayToInt(string day)
    {
        var s = day.Split('.');
        int res = 0;
        res += int.Parse(s[0]) * 28 * 12;
        res += int.Parse(s[1]) * 28;
        res += int.Parse(s[2]);
        return res;
    }

    public int[] solution(string today, string[] terms, string[] privacies)
    {
        List<int> answer = new List<int>();
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (string term in terms)
        {
            char key = term[0];
            int value = int.Parse(term.Substring(2)) * 28;

            if (!dict.TryAdd(key, value))
                dict[key] = value;
        }
        int int_today = DayToInt(today);
        for (int i = 0; i < privacies.Length; i++)
        {
            string[] s = privacies[i].Split(' ');
            int p = DayToInt(s[0]) + dict[s[1][0]];
            Console.WriteLine(int_today + " " + p);
            if (int_today >= p)
                answer.Add(i + 1);
        }
        return answer.ToArray();
    }
}