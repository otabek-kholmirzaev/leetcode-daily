public class Solution {
    public int TupleSameProduct(int[] nums) {
        Dictionary<int, int> map = new();
        int n = nums.Length;
        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                int res = nums[i] * nums[j];
                if (!map.ContainsKey(res)) map[res] = 0;
                map[res]++;
            }
        }

        return map.Values.Sum(x => x * (x - 1) * 4);
    }
}