using System;
using System.Linq;

public class Solution
{
    public string[] solution(string[] strings, int n)
    {
        Array.Sort(strings, (a, b) => a[n].CompareTo(b[n]) == 0 ? a.CompareTo(b) : a[n].CompareTo(b[n]));
        return strings;
        //return strings.OrderBy(str => str).OrderBy(str => str[n]).ToArray();
    }
}