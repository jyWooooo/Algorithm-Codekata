using System;

public class Solution
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        int[] winning = new int[] { 6, 6, 5, 4, 3, 2, 1 };
        int zeroCnt = 0;
        int correctCnt = 0;
        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0)
            {
                zeroCnt++;
                continue;
            }
            for (int j = 0; j < win_nums.Length; j++)
            {
                if (win_nums[j] == lottos[i])
                {
                    correctCnt++;
                    break;
                }
            }
        }
        return new int[] { winning[correctCnt + zeroCnt], winning[correctCnt] };
    }
}