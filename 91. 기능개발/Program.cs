using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        List<int> answer = new List<int>();
        List<int> progress = progresses.ToList();
        List<int> speed = speeds.ToList();

        while (progress.Count > 0)
        {
            for (int i = 0; i < progress.Count; i++)
                progress[i] += speed[i];

            int a = 0;
            for (int i = 0; i < progress.Count; i++)
            {
                if (progress[i] >= 100)
                    a++;
                else break;
            }

            progress.RemoveRange(0, a);
            speed.RemoveRange(0, a);
            if (a > 0) answer.Add(a);
        }

        return answer.ToArray();
    }
}