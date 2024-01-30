public class Solution
{
    public void DFS(int x, int y, int size, int[,] arr, int[] answer)
    {
        bool flag = true;
        for (int i = x; i < x + size; i++)
        {
            for (int j = y; j < y + size; j++)
            {
                if (arr[i, j] != arr[x, y])
                {
                    flag = false;
                    break;
                }
            }
        }

        if (size == 1 || flag)
        {
            answer[arr[x, y]]++;
            return;
        }

        size /= 2;
        DFS(x, y, size, arr, answer);
        DFS(x + size, y, size, arr, answer);
        DFS(x, y + size, size, arr, answer);
        DFS(x + size, y + size, size, arr, answer);
    }

    public int[] solution(int[,] arr)
    {
        int[] answer = new int[] { 0, 0 };
        DFS(0, 0, arr.GetLength(0), arr, answer);
        return answer;
    }
}