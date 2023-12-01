using System;
using System.Collections.Generic;
using System.Linq;

//public class Solution
//{
//    public int[] solution(int k, int[] score)
//    {
//        List<int> rankers = new List<int>();
//        List<int> answer = new List<int>();
//        for (int i = 0; i < score.Length; i++)
//        {
//            rankers.Add(score[i]);
//            rankers.Sort();
//            if (rankers.Count > k)
//                rankers.RemoveAt(0);
//            answer.Add(rankers[0]);
//        }
//        return answer.ToArray();
//    }
//}

public class Solution
{
    public int[] solution(int k, int[] score)
    {
        PriorityQueue<int, int> rankers = new PriorityQueue<int, int>();
        List<int> answer = new List<int>();
        for (int i = 0; i < score.Length; i++)
        {
            rankers.Enqueue(score[i], score[i]);
            if (rankers.Count > k)
                rankers.Dequeue();
            answer.Add(rankers.Peek());
        }
        return answer.ToArray();
    }
}