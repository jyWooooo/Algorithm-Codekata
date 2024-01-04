using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(string[] want, int[] number, string[] discount)
    {
        int answer = 0;
        Dictionary<string, int> dict = new Dictionary<string, int>();
        for (int i = 0; i < want.Length; i++)
            dict.Add(want[i], number[i]);
        for (int i = 0; i <= discount.GetLength(0) - 10; i++)
        {
            var wants = new Dictionary<string, int>(dict);
            for (int j = i; j < i + 10; j++)
            {
                if (wants.ContainsKey(discount[j]))
                    wants[discount[j]]--;
            }
            if (wants.Select(x => x.Value).Max() == 0)
                answer++;
        }

        return answer;
    }
}