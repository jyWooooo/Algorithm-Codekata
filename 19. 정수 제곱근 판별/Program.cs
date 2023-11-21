using System;

public class Solution
{
    public long solution(long n)
    {
        var d = Math.Sqrt(n);
        return (long)d - d == 0 ? (long)(d * d) : -1;
    }
}