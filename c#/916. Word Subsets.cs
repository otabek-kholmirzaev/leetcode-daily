// https://leetcode.com/problems/word-subsets/

public class Solution {
    public IList<string> WordSubsets(string[] words1, string[] words2) {
        var max_count2 = new int[26];
        foreach (var w in words2) {
            var count2 = new int[26];
            foreach (var c in w) count2[c - 'a']++;
            for (int i = 0; i < 26; i++) max_count2[i] = Math.Max(max_count2[i], count2[i]);
        }

        var ans = new List<string>();
        foreach (var w in words1) {
            var count1 = new int[26];
            foreach (var c in w) count1[c - 'a']++; 

            bool universal = true;
            for (int i = 0; i < 26; i++) {
                if (count1[i] < max_count2[i]) {
                    universal = false;
                    break;
                }
            } 

            if (universal) ans.Add(w);
        } 

        return ans;
    }
}