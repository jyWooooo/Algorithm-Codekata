using System.Linq;

public class Solution
{
    public int[] solution(int[] arr, int divisor)
    {
        int[] answer = arr.Where(x => x % divisor == 0).ToArray().OrderBy(x => x).ToArray();
        if (answer.Length == 0) answer = new int[1] { -1 };
        return answer;
    }
}