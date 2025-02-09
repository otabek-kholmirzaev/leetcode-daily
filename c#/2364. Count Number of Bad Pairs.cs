public class Solution {
    public long CountBadPairs(int[] nums) {
        Dictionary<int, int> map = new();
        long ans = 0;
        for (int i = 0; i < nums.Length; i++) {
            int val = i - nums[i];

            if (map.ContainsKey(val)) {
                ans += i - map[val];
                map[val]++;
            } 
            else {
                ans += i;
                map[val] = 1;
            }
        }

        return ans;
    }
}