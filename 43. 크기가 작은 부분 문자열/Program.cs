using System;

public class Solution
{
    public int solution(string t, string p)
    {
        int answer = 0;
        long n = long.Parse(p);
        for (int i = 0; i < t.Length - p.Length + 1; i++)
        {
            var current = t.Substring(i, p.Length);
            if (long.Parse(current) <= n)
                answer++;
        }
        return answer;
    }
}