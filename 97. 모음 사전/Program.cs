using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string[] alpha = { "A", "E", "I", "O", "U" };
    List<string> dict = new List<string>();

    public void DFS(int depth, int length, string str)
    {
        if (depth == length)
        {
            dict.Add(str);
            return;
        }
        for (int i = 0; i < 5; i++)
            DFS(depth + 1, length, str + alpha[i]);
    }

    public int solution(string word)
    {
        for (int i = 1; i <= 5; i++)
            DFS(0, i, "");

        dict = dict.OrderBy(x => x).ToList();

        for (int i = 0; i < dict.Count; i++)
        {
            if (dict[i] == word)
                return i + 1;
        }

        return 0;
    }
}