using System;

public class Solution
{
    public int solution(int n)
    {
        int divider = 1;
        int answer = 0;
        while (divider <= n)
        {
            answer += (n / divider) % 10;
            divider *= 10;
        }

        return answer;
    }
}