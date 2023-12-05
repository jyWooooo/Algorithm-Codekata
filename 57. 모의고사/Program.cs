using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] answers)
    {
        int[][] cycles = new int[3][] {
            new int[]{ 1, 2, 3, 4, 5 },
            new int[]{ 2, 1, 2, 3, 2, 4, 2, 5 },
            new int[]{ 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 }
        };
        List<int> answer = new List<int>();
        int[] scores = new int[3] { 0, 0, 0 };
        for (int i = 0; i < answers.Length; i++)
        {
            scores[0] += answers[i] == cycles[0][i % cycles[0].Length] ? 1 : 0;
            scores[1] += answers[i] == cycles[1][i % cycles[1].Length] ? 1 : 0;
            scores[2] += answers[i] == cycles[2][i % cycles[2].Length] ? 1 : 0;
        }
        int max = scores.Max();
        for (int i = 0; i < scores.Length; i++)
            if (scores[i] == max)
                answer.Add(i + 1);
        return answer.ToArray();
    }
}