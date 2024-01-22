using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        int[] answer = new int[numbers.Length];
        answer = answer.Select(x => x = -1).ToArray();
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            while (stack.Count != 0 && numbers[stack.Peek()] < numbers[i])
                answer[stack.Pop()] = numbers[i];
            stack.Push(i);
        }
        return answer;
    }
}