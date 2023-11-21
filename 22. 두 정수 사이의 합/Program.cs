public class Solution
{
    public long cal(int a, int b)
    {
        long sum = 0;
        for (int i = a; i <= b; i++)
            sum += i;
        return sum;
    }

    public long solution(int a, int b)
    {
        return a < b ? cal(a, b) : cal(b, a);
        // 등차수열의 합 공식으로 풀면 빠름
        //return (long)(System.Math.Abs(a - b) + 1) * (a + b) / 2;
    }
}