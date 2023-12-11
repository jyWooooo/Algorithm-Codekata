using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] keymap, string[] targets)
    {
        int[] answer = new int[targets.Length];
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (string key in keymap)
        {
            for (int i = 0; i < key.Length; i++)
            {
                char c = key[i];
                if (dict.TryGetValue(c, out int value))
                    dict[c] = Math.Min(value, i + 1);
                else
                    dict.Add(c, i + 1);
            }
        }

        for (int i = 0; i < targets.Length; i++)
        {
            foreach (char c in targets[i])
            {
                if (dict.TryGetValue(c, out int value))
                    answer[i] += value;
                else
                {
                    answer[i] = -1;
                    break;
                }
            }
        }

        return answer;
    }
}