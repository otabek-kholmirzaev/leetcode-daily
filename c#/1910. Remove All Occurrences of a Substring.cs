public class Solution {
    public string RemoveOccurrences(string s, string part) {
        while (true) {
            int i = s.IndexOf(part); 
            if (i == -1) break;
            s = s[0..i] + s[(i + part.Length)..];
        }

        return s;
    }
}