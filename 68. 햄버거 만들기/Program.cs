using System.Collections.Generic;

public class Solution
{
    public int solution(int[] ingredient)
    {
        int answer = 0;
        Stack<int> stack = new Stack<int>();

        foreach (int item in ingredient)
        {
            if (item == 1 && stack.TryPeek(out var top))
            {
                if (top == 3)
                {
                    for (int i = 0; i < 3; i++)
                        stack.Pop();
                    answer++;
                    continue;
                }
            }

            if (item == 1)
                stack.Push(item);
            else if (stack.TryPeek(out top))
            {
                if (item - 1 == top)
                    stack.Push(item);
                else
                    stack.Clear();
            }
        }

        return answer;
    }
}