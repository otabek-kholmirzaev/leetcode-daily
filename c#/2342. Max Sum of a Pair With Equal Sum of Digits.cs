public class Solution {
    public int MaximumSum(int[] nums) {
        Dictionary<int, (int max, int next_max)> map = new();
        foreach (var num in nums) {
            int sum = DigitsSum(num);
            if (!map.ContainsKey(sum)) map[sum] = (-1, -1);
            var temp = new int[] { num, map[sum].max, map[sum].next_max };
            Array.Sort(temp);
            map[sum] = (temp[2], temp[1]);
        }
        
        int ans = -1;
        foreach (var (max, next_max) in map.Values) {
            if (next_max != -1) {
                ans = Math.Max(ans, max + next_max);
            }
        }

        return ans;
    }

    private int DigitsSum(int n) {
        int s = 0;
        while (n > 0) { s += n % 10; n /= 10; }
        return s;
    }
}