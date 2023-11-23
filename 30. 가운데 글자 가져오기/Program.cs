public class Solution
{
    public string solution(string s)
    {
        return s.Substring((s.Length - 1) / 2, s.Length % 2 == 0 ? 2 : 1);
    }
}