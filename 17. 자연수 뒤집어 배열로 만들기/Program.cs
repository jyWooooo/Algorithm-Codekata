using System.Linq;

public class Solution
{
    public int[] solution(long n)
    {
        string str = new string(n.ToString().Reverse().ToArray());
        return str.Select(x => int.Parse(x.ToString())).ToArray();
    }
}