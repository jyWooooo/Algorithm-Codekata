using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] elements)
    {
        int[] sums = (int[])elements.Clone();
        HashSet<int> set = new HashSet<int>(elements);

        for (int i = 1; i < elements.Length; i++)
        {
            for (int j = 0; j < elements.Length; j++)
            {
                sums[j] += elements[(i + j) % elements.Length];
                set.Add(sums[j]);
            }
        }

        return set.Count;
    }
}