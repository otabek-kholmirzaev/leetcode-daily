// https://leetcode.com/problems/construct-k-palindrome-strings/

public class Solution {
    public bool CanConstruct(string s, int k) => 
        s.Length >= k && s.GroupBy(c => c).Count(g => g.Count() % 2 == 1) <= k;
}