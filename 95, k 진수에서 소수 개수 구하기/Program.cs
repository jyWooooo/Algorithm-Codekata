using System;
using System.Linq;

public class Solution
{
    public bool IsPrime(string str)
    {
        long n = long.Parse(str);

        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public string ConvertK(int n, int k)
    {
        string num = "";
        while (true)
        {
            int m = n / k;
            num += (n % k).ToString();
            if (m == 0)
                break;
            n = m;
        }
        return new string(num.Reverse().ToArray());
    }

    public int solution(int n, int k)
    {
        int answer = 0;

        string num = ConvertK(n, k);

        var splits = num.Split('0');

        foreach (var split in splits)
        {
            if (split.Equals(string.Empty))
                continue;

            if (IsPrime(split))
                answer++;
        }

        return answer;
    }
}