using System;

public class Solution
{
    public string solution(string s)
    {
        var splits = s.Split(' ');
        int min = int.MaxValue;
        int max = int.MinValue;
        foreach (var split in splits)
        {
            min = Math.Min(min, int.Parse(split));
            max = Math.Max(max, int.Parse(split));
        }
        return $"{min} {max}";
    }
}