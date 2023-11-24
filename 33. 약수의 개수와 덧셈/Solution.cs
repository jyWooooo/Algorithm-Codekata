using System;

public class Solution
{
    public int Cal(int x)
    {
        int cnt = 0;
        for (int i = 1; i <= x; i++)
        {
            if (x % i == 0)
                cnt++;
        }
        return cnt;
    }

    public int solution(int left, int right)
    {
        int answer = 0;
        for (int i = left; i <= right; i++)
        {
            int cnt = Cal(i);
            answer += cnt % 2 == 0 ? i : -i;
        }
        return answer;
    }
}