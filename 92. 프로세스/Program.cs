using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] priorities, int location)
    {
        int answer = 0;

        List<int> pq = new List<int>();
        Queue<(int idx, int priority)> q = new Queue<(int idx, int priority)>();

        for (int i = 0; i < priorities.Length; i++)
        {
            pq.Add(priorities[i]);
            q.Enqueue((i, priorities[i]));
        }

        pq = pq.OrderByDescending(x => x).ToList();

        while (q.Count > 0)
        {
            (int idx, int priority) peek = q.Dequeue();

            if (pq[0] == peek.priority)
            {
                pq.RemoveAt(0);
                answer++;

                if (peek.idx == location)
                    break;
            }
            else
                q.Enqueue(peek);
        }

        return answer;
    }
}