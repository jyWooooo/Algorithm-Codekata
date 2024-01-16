using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int answer = 0;
    public bool[] visited;
    public int n;

    public void DFS(int k, bool[] visited, int[,] dungeons, int cnt)
    {
        for (int i = 0; i < n; i++)
        {
            if (!visited[i] && k >= dungeons[i, 0])
            {
                visited[i] = true;
                DFS(k - dungeons[i, 1], visited, dungeons, cnt + 1);
                visited[i] = false;
            }
        }
        answer = Math.Max(answer, cnt);
    }

    public int solution(int k, int[,] dungeons)
    {
        n = dungeons.GetLength(0);
        visited = new bool[n];
        DFS(k, visited, dungeons, 0);
        return answer;
    }
}