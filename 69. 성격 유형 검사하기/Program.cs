using System;

public class Solution
{
    public string solution(string[] survey, int[] choices)
    {
        string answer = "";
        char[][] table = new char[][]
        {
            new char[]{ 'R', 'T' },
            new char[]{ 'C', 'F' },
            new char[]{ 'J', 'M' },
            new char[]{ 'A', 'N' },
        };
        int[] scores = new int[4];

        for (int i = 0; i < survey.Length; i++)
        {
            int score = choices[i] - 4;

            for (int j = 0; j < table.Length; j++)
            {
                if (survey[i][0] == table[j][0])
                {
                    scores[j] += score;
                    break;
                }
                else if (survey[i][0] == table[j][1])
                {
                    scores[j] -= score;
                    break;
                }
            }
        }

        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] <= 0)
                answer += table[i][0];
            else
                answer += table[i][1];
        }

        return answer;
    }
}