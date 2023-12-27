using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;

        int maxRound = 0;
        while (n >= 2)
        {
            maxRound++;
            n /= 2;
        }

        for (int i = 0; i < maxRound; i++)
        {
            answer++;
            a = a % 2 == 0 ? a / 2 : a / 2 + 1;
            b = b % 2 == 0 ? b / 2 : b / 2 + 1;
            if (a == b) return answer;
        }

        return answer;
    }
}