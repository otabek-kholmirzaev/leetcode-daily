// https://leetcode.com/problems/count-ways-to-build-good-strings/

public class Solution {
    public int CountGoodStrings(int low, int high, int zero, int one) {
        var dp = new int[high + 1];
        dp[one] += 1;
        dp[zero] += 1;
        int m = 1_000_000_007;
        for (int i = 0; i <= high; i++) {
            if (i + one <= high && dp[i] > 0) dp[i + one] = (dp[i + one] + dp[i]) % m;
            if (i + zero <= high && dp[i] > 0) dp[i + zero] = (dp[i + zero] + dp[i]) % m;
        }

        int ans = 0;
        for (int i = low; i <= high; i++) ans = (ans + dp[i]) % m;

        return ans;
    }
}