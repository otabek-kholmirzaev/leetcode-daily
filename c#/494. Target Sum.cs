// https://leetcode.com/problems/target-sum/description/

public class Solution {
    int count;
    int target;
    int[] nums;
    public int FindTargetSumWays(int[] nums, int target) {
        this.target = target;
        this.nums = nums;
        count = 0;
        dfs(0, 0);
        return count;
    }

    void dfs(int i, int curr) {
        if (i >= nums.Length) {
            if (target == curr) count++;
            return;
        }
        dfs(i + 1, curr + nums[i]);
        dfs(i + 1, curr - nums[i]);
    }
}