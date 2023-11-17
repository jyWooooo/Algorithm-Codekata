public class Solution
{
    public double solution(int[] arr)
    {
        double avg = 0;
        int sum = 0;
        for (int i = 0; i < arr.Length; i++) 
            sum += arr[i];
        avg = (double)sum / arr.Length;
        return avg;
    }
}