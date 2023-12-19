using System;

public class Solution
{
    public int[] FindStartPoint(string[] park)
    {
        for (int i = 0; i < park.Length; i++)
        {
            for (int j = 0; j < park[i].Length; j++)
            {
                if (park[i][j] == 'S')
                    return  new int[] { i, j };
            }
        }

        return new int[] { 0, 0 };
    }

    public int[] IsVailid(int[] start, string route, string[] park)
    {
        char op = route[0];
        int n = route[2] - '0';
        int[] dxdy = new int[] { 0, 0 };
        switch (op)
        {
            case 'N':
                dxdy[0] -= 1;
                break;
            case 'S':
                dxdy[0] += 1;
                break;
            case 'W':
                dxdy[1] -= 1;
                break;
            case 'E':
                dxdy[1] += 1;
                break;
        }

        var temp = new int[] { start[0], start[1] };
        for (int i = 0; i < n; i++)
        {
            if (!(0 <= temp[0] + dxdy[0] && temp[0] + dxdy[0] < park.Length))
                return start;
            if (!(0 <= temp[1] + dxdy[1] && temp[1] + dxdy[1] < park[0].Length))
                return start;

            if (park[temp[0] + dxdy[0]][temp[1] + dxdy[1]] == 'X')
                return start;

            temp[0] += dxdy[0];
            temp[1] += dxdy[1];
        }
        return temp;
    }

    public int[] solution(string[] park, string[] routes)
    {
        int[] answer = FindStartPoint(park);
        foreach (string route in routes)
            answer = IsVailid(answer, route, park);
        return answer;
    }
}