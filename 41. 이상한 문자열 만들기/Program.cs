public class Solution
{
    public string solution(string s)
    {
        string answer = "";

        var splits = s.Split(' ');

        foreach(var str in splits)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                    answer += char.ToUpper(str[i]);
                else
                    answer += char.ToLower(str[i]);
            }
            answer += ' ';
        }
        answer = answer.Remove(answer.Length - 1);
        return answer;
    }
}