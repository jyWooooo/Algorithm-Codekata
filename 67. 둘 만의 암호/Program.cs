using System;

public class Solution
{
    public string solution(string s, string skip, int index)
    {
        string answer = "";
        foreach (char c in s)
        {
            char newChar = c;
            for (int i = 0; i < index; i++)
            {
                newChar++;
                if (newChar > 'z') newChar = 'a';
                if (skip.Contains(newChar))
                    i--;
            }
            answer += newChar;
        }
        return answer;
    }
}