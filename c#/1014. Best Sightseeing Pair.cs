// https://leetcode.com/problems/best-sightseeing-pair/

public class Solution {
    public int MaxScoreSightseeingPair(int[] values) {
        int max = 0, ans = 0;
        for (int i = 0; i < values.Length; i++) {
            ans = Math.Max(ans, values[i] - i + max);
            max = Math.Max(max, values[i] + i);
        }

        return ans;
    }
}