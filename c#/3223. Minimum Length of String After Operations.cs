// https://leetcode.com/problems/minimum-length-of-string-after-operations/

public class Solution {
    public int MinimumLength(string s) {
        var freq = new int[26];
        foreach (var c in s) {
            freq[c - 'a']++;
            if (freq[c - 'a'] >= 3) freq[c - 'a'] -= 2; 
        }

        return freq.Sum();
    }
}