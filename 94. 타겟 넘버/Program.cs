public class Solution
{
    public int answer = 0;
    public void DFS(int[] nums, int target, int current, int depth)
    {
        if (depth == nums.Length)
        {
            if (current == target)
                answer++;
            return;
        }

        DFS(nums, target, current + nums[depth], depth++);
        DFS(nums, target, current - nums[depth], depth++);
    }

    public int solution(int[] numbers, int target)
    {
        DFS(numbers, target, 0, 0);
        return answer;
    }
}