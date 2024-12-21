// https://leetcode.com/problems/two-sum/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();
        for (int i = 0; i < nums.Length; i++) {
            if (dict.TryGetValue(target - nums[i], out int j))
                return new int[] { i, j };

            dict[nums[i]] = i; 
        }

        return null;
    }
}