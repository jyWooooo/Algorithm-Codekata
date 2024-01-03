public class Solution
{
    public int[] solution(int n, long left, long right)
    {
        int[] answer = new int[right - left + 1];

        for (long i = left; i <= right; i++)
        {
            int temp = (i / n) >= (i % n) ? (int)(i / n + 1) : (int)(i % n + 1);
            answer[i - left] = temp;
        }

        return answer;
    }
}