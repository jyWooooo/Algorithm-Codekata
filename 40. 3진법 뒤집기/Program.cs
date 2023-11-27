using System;
using System.Linq;

public class Solution
{
    public string Convert(int n)
    {
        string res = "";
        while (n >= 3)
        {
            res = (n % 3).ToString() + res;
            n /= 3;
        }
        res = n.ToString() + res;
        return res;
    }

    public int Convert(string s)
    {
        int n = 0;
        int b = 1;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            n += (s[i] - '0') * b;
            b *= 3;
        }
        return n;
    }

    public int solution(int n)
    {
        string a = Convert(n);
        a = new string(a.Reverse().ToArray());
        return Convert(a);
    }
}