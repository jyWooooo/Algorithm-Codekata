using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        int answer = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < tangerine.Length; i++)
        {
            if (!dict.TryAdd(tangerine[i], 1))
                dict[tangerine[i]] += 1;
        }

        var list = dict.Select(item => item.Value).OrderByDescending(item => item).ToList();

        foreach (var e in list)
        {
            if (k <= 0)
                break;

            k -= e;
            answer++;
        }

        return answer;
    }
}