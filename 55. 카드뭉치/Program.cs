using System;

public class Solution
{
    public string solution(string[] cards1, string[] cards2, string[] goal)
    {
        int hand1 = 0;
        int hand2 = 0;
        string card1 = "";
        string card2 = "";

        foreach (var word in goal)
        {
            card1 = hand1 < cards1.Length ? cards1[hand1] : "";
            card2 = hand2 < cards2.Length ? cards2[hand2] : "";

            if (word == card1)
                hand1++;
            else if (word == card2)
                hand2++;
            else
                return "No";
        }
        return "Yes";
    }
}