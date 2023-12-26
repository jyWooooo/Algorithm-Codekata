public class Solution
{
    public int[] solution(int brown, int yellow)
    {
        int w = 0;
        int h = 0;

        for (int n = 1; n * n <= yellow; n++)
        {
            if (yellow % n == 0)
            {
                w = yellow / n;
                h = n;
                if ((w + h) * 2 + 4 == brown)
                    return new int[] { w + 2, h + 2 };
            }
        }

        return null;
    }
}