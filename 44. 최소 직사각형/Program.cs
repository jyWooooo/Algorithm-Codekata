using System;

public class Solution
{
    public int solution(int[,] sizes)
    {
        int maxWidth = 0;
        int maxHeight = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i, 0] < sizes[i, 1])
            {
                int temp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = temp;
            }

            maxWidth = Math.Max(maxWidth, sizes[i, 0]);
            maxHeight = Math.Max(maxHeight, sizes[i, 1]);
        }

        return maxWidth * maxHeight;
    }
}