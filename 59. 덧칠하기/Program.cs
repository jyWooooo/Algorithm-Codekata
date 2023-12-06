using System;

public class Solution
{
    public int solution(int n, int m, int[] section)
    {
        int answer = 0;
        bool[] wall = new bool[n];
        foreach (int i in section)
            wall[i - 1] = true;
        for (int i = 0; i < n; i++)
        {
            if (wall[i])
            {
                for (int j = i; j < i + m && j < n; j++)
                    wall[j] = false;
                answer++;
            }
        }
        return answer;
    }
}