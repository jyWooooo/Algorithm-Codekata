using System;

public class Solution
{
    public int solution(string[] babbling)
    {
        int answer = 0;
        string[] canSpeek = new string[] { "aya", "ye", "woo", "ma" };
        foreach (var bab in babbling) 
        {
            string s = bab;
            for (int i = 0; i <  canSpeek.Length; i++)
                s = s.Replace(canSpeek[i], i.ToString());
            int lastSpeek = -1;
            bool flag = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (int.TryParse(s[i].ToString(), out var currentSpeek))
                {
                    if (currentSpeek == lastSpeek)
                    {
                        flag = false;
                        break;
                    }
                    lastSpeek = currentSpeek;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (flag) answer++;
        }

        return answer;
    }
}