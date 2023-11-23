using System;
using System.Linq;

public class Solution
{
    public int solution(int[] numbers)
    {
        return 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 - numbers.Sum();
    }
}