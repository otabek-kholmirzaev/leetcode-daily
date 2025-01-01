// https://leetcode.com/problems/maximum-score-after-splitting-a-string/

public class Solution {
    public int MaxScore(string s) {
        int n = s.Length;
        int ans = 0;
        for (int i = 0; i < n-1; i++) {
            int zeros = 0; 
            for (int j = 0; j <= i; j++) {
                if (s[j] == '0') zeros++;
            }

            int ones = 0; 
            for (int j = i+1; j < n; j++) {
                if (s[j] == '1') ones++;
            }

            ans = Math.Max(ans, zeros + ones);
        }

        return ans;
    }
}