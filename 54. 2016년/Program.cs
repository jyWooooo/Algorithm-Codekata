public class Solution
{
    public string solution(int a, int b)
    {
        int deltaDay = 0;
        int[] month = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] week = new string[] { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU", };
        for (int i = 0; i < a - 1; i++)
            deltaDay += month[i];
        deltaDay += b - 1;
        deltaDay %= 7;
        return week[deltaDay];

        //System.DateTime dateTime = new System.DateTime(2016, a, b);
        //return dateTime.ToString("ddd").ToUpper();
    }
}