using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            //int skip = commands[i, 0] - 1;
            //int take = commands[i, 1] - skip;
            int start = commands[i, 0] - 1;
            int end = commands[i, 1];
            int k = commands[i, 2] - 1;
            //answer[i] = array.Skip(skip).Take(take).OrderBy(x => x).ToArray()[k];
            answer[i] = array.Where((x, idx) => idx >= start && idx < end).OrderBy(x => x).ToArray()[k];
        }

        return answer;
    }
}