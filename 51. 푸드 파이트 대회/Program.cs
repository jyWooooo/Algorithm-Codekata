using System;
using System.Linq;

public class Solution
{
    public string solution(int[] food)
    {
        string answer = "";
        for (int i = 1; i < food.Length; i++)
            answer += new string((char)(i + '0'), food[i] / 2);
        answer += "0" + new string(answer.Reverse().ToArray());
        return answer;
    }
}