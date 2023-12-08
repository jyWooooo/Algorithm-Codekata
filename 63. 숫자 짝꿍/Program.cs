using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string X, string Y)
    {
        string answer = "";
        int[] XCounts = new int[10];
        int[] YCounts = new int[10];
        X.Select(x => XCounts[x - '0']++).ToArray();
        Y.Select(x => YCounts[x - '0']++).ToArray();
        for (int i = 9; i >= 0; i--)
            answer += new string((char)(i + '0'), Math.Min(XCounts[i], YCounts[i]));
        if (answer.Length == 0)
            return "-1";
        if (answer.Max(x => x - '0') == 0)
            return "0";
        return answer;
    }
}