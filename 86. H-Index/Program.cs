using System;

public class Solution
{
    public int solution(int[] citations)
    {
        Array.Sort(citations, (a, b) => b.CompareTo(a));

        for (int i = 0; i < citations.Length; i++)
        {
            if (citations[i] < i + 1)
                return i;
        }
        return citations.Length;
    }
}