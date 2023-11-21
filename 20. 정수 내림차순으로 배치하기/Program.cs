using System.Linq;

public class Solution
{
    public long solution(long n)
    {
        string str = n.ToString();
        str = new string(str.OrderByDescending(x => x).ToArray());
        return long.Parse(str);
    }
}