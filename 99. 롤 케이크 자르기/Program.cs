using System.Collections.Generic;

public class Solution
{
    public int solution(int[] topping)
    {
        int answer = 0;
        Dictionary<int, int> m1 = new Dictionary<int, int>();
        Dictionary<int, int> m2 = new Dictionary<int, int>();

        foreach (int i in topping)
            if (!m1.TryAdd(i, 1))
                m1[i]++;

        foreach (int i in topping)
        {
            m1[i]--;
            if (m1[i] == 0)
                m1.Remove(i);
            if (!m2.TryAdd(i, 1))
                m2[i]++;

            if (m1.Count == m2.Count)
                answer++;
        }

        return answer;
    }
}