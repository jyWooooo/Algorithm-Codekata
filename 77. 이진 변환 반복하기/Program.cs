using System;
using System.Linq;

public class Solution
{
    public int[] solution(string s)
    {
        int n = 0;
        int total = 0;

        while (s != "1")
        {
            int zeroCnt = s.Count(e => e == '0');
            total += zeroCnt;
            n++;

            int newLength = s.Length - zeroCnt;
            s = Convert.ToString(newLength, 2);
        }
        return new int[] { n, total };
    }
}