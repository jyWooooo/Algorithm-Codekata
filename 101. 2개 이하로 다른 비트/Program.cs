using System;

public class Solution
{
    public long[] solution(long[] numbers)
    {
        long[] answer = new long[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            long res = numbers[i] ^ (numbers[i] + 1);
            res >>= 2;
            res += numbers[i] + 1;
            answer[i] = res;
        }
        return answer;
    }
}