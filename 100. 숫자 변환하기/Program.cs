using System;
using System.Linq;

public class Solution
{
    public int solution(int x, int y, int n)
    {
        int[] dp = new int[y + 1];
        dp = dp.Select(item => int.MaxValue).ToArray();
        dp[y] = 0;
        for (int i = y; i > 0; i--)
        {
            if (dp[i] == int.MaxValue)
                continue;

            if (i - n > 0)
                dp[i - n] = Math.Min(dp[i - n], dp[i] + 1);
            if (i % 2 == 0)
                dp[i / 2] = Math.Min(dp[i / 2], dp[i] + 1);
            if (i % 3 == 0)
                dp[i / 3] = Math.Min(dp[i / 3], dp[i] + 1);
        }
        return dp[x] == int.MaxValue ? -1 : dp[x];
    }
}