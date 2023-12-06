using System;

//public class Solution
//{
//    public int DivisorCount(int n)
//    {
//        int cnt = 0;
//        for (int i = 1; i <= Math.Sqrt(n); i++)
//        {
//            if (i * i == n)
//                cnt++;
//            else if (n % i == 0)
//                cnt += 2;
//        }
//        return cnt;
//    }

//    public int solution(int number, int limit, int power)
//    {
//        int answer = 0;
//        for (int i = 1; i <= number; i++)
//            answer += DivisorCount(i) <= limit ? DivisorCount(i) : power;
//        return answer;
//    }
//}

public class Solution
{
    public int solution(int number, int limit, int power)
    {
        int answer = 0;
        int[] divisorCounts = new int[number];
        for (int i = 1; i <= number; i++)
            for (int j = i; j <= number; j += i)
                divisorCounts[j - 1]++;
        for (int i = 0; i < divisorCounts.Length; i++)
            answer += divisorCounts[i] <= limit ? divisorCounts[i] : power;
            return answer;
    }
}