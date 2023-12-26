using System;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        s = s.ToLower();
        char lastChar = ' ';

        for (int i = 0; i < s.Length; i++)
        {
            if (lastChar == ' ')
                answer += char.ToUpper(s[i]);
            else
                answer += s[i];
            lastChar = s[i];
        }

        return answer;
    }
}