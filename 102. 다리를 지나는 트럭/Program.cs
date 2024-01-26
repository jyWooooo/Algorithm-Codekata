using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int bridge_length, int weight, int[] truck_weights)
    {
        Queue<int> queue = new Queue<int>();
        int[] start = new int[truck_weights.Length];
        int time = 0;
        int currentWeight = 0;
        int count = 0;
        while (count < truck_weights.Length)
        {
            if (queue.Count == 0 || weight - currentWeight >= truck_weights[count])
            {
                time++;
                start[count] = time;
                queue.Enqueue(count);
                currentWeight += truck_weights[count];
                count++;
            }
            else
            {
                int front = queue.Dequeue();
                time = Math.Max(start[front] + bridge_length - 1, time);
                currentWeight -= truck_weights[front];
            }
        }
        return start[truck_weights.Length - 1] + bridge_length;
    }
}