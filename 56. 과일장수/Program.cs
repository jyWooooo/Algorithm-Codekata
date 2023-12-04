using System;
using System.Linq;

public class Solution
{
    public int solution(int k, int m, int[] score)
    {
        int answer = 0;
        Array.Sort(score, (a, b) => -a.CompareTo(b));
        for (int i = 0; i < score.Length; i++)
        {
            if ((i + 1) % m == 0)
                answer += score[i] * m;
        }
        return answer;
    }
}