using System;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;
        int[] dict = new int[2] { 0, 0 };
        char x = '\0';
        foreach (char c in s)
        {
            if (x == '\0')
                x = c;
            if (x == c)
                dict[0]++;
            else
                dict[1]++;

            if (dict[0] == dict[1])
            {
                answer++;
                dict = new int[2] { 0, 0 };
                x = '\0';
            }
        }    

        if (dict[0] != 0)
            answer++;

        return answer;
    }
}