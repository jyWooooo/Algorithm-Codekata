public class Solution
{
    public int solution(int a, int b, int n)
    {
        int answer = 0;
        while (n >= a)
        {
            int mod = n % a;
            int get = (n / a) * b;
            answer += get;
            n = mod + get;
        }
        return answer;
    }
}