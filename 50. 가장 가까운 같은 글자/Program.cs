using System.Collections.Generic;

public class Solution
{
    public int[] solution(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int[] answer = new int[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                answer[i] = i - dict[s[i]];
                dict[s[i]] = i;
            }
            else
            {
                dict.Add(s[i], i);
                answer[i] = -1;
            }
        }
        return answer;
    }
}