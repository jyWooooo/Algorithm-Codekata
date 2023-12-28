using System.Collections.Generic;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;
        Stack<char> stack = new Stack<char>();
        Queue<char> queue = new Queue<char>(s);
        for (int i = 0; i < queue.Count; i++)
        {
            stack.Clear();
            foreach (var e in queue)
            {
                if (stack.TryPeek(out char peek))
                {
                    if (peek == '(' && e == ')')
                        stack.Pop();
                    else if (peek == '{' && e == '}')
                        stack.Pop();
                    else if (peek == '[' && e == ']')
                        stack.Pop();
                    else
                        stack.Push(e);
                }
                else
                    stack.Push(e);
            }
            if (stack.Count == 0)
                answer++;
            queue.Enqueue(queue.Dequeue());
        }
        return answer;
    }
}