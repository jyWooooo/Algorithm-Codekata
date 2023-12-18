using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] players, string[] callings)
    {
        Dictionary<string, int> rank = new Dictionary<string, int>();
        for (int i = 0; i < players.Length; i++)
            rank.Add(players[i], i);

        foreach (var name in callings)
        {
            int i = rank[name];
            string prev = players[i - 1];

            var temp = players[i];
            players[i] = players[i - 1];
            players[i - 1] = temp;

            rank[name] = i - 1;
            rank[prev] = i;
        }

        return players;
    }
}