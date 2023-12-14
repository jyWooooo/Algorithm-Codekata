using System;

public class Solution
{
    public int[] solution(string[] wallpaper)
    {
        int[] answer = new int[] { int.MaxValue, int.MaxValue, 0, 0 };

        for (int x = 0; x < wallpaper.Length; x++)
        {
            for (int y = 0; y < wallpaper[x].Length; y++)
            {
                if (wallpaper[x][y] == '#')
                {
                    answer[0] = Math.Min(answer[0], x);
                    answer[1] = Math.Min(answer[1], y);
                    answer[2] = Math.Max(answer[2], x + 1);
                    answer[3] = Math.Max(answer[3], y + 1);
                }
            }
        }

        return answer;
    }
}