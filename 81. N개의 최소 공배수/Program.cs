using System.Linq;

public class Solution
{
    public int solution(int[] arr)
    {
        int maxValue = arr.Max();
        int currentValue = maxValue;
        while (true)
        {
            bool check = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (currentValue % arr[i] != 0)
                {
                    check = false;
                    break;
                }
            }
            
            if (check)
                return currentValue;
            else
                currentValue += maxValue;
        }
    }
}