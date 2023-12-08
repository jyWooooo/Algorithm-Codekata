using System.Linq;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        int answer = 0;
        int[] student = new int[n + 2];
        for (int i = 0; i < student.Length; i++) student[i] = 1;
        foreach (var e in lost) student[e]--;
        foreach (var e in reserve) student[e]++;
        student[0] = -1;
        student[n + 1] = -1;

        for (int i = 1; i < student.Length - 1; i++)
        {
            if (student[i] == 0)
            {
                if (student[i - 1] == 2)
                {
                    student[i]++;
                    student[i - 1]--;
                }
                else if (student[i + 1] == 2)
                {
                    student[i]++;
                    student[i + 1]--;
                }
            }
            if (student[i] >= 1) answer++;
        }

        return answer;
    }
}
