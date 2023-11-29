public class Solution
{
    public string solution(string s, int n)
    {
        string answer = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLower(s[i]))
            {
                char c = (char)(s[i] + n > 'z' ? s[i] + n - 'z' + 'a' - 1 : s[i] + n);
                answer += c;
            }
            else if (char.IsUpper(s[i]))
            {
                char c = (char)(s[i] + n > 'Z' ? s[i] + n - 'Z' + 'A' - 1 : s[i] + n);
                answer += c;
            }
            else answer += s[i];
        }

        return answer;
    }
}