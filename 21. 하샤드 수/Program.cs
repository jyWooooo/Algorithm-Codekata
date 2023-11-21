public class Solution
{
    public bool solution(int x)
    {
        int sum = 0;
        for (int i = 1; i <= x; i *= 10)
            sum += (x % (i * 10)) / i;
        return x % sum == 0;
    }
}