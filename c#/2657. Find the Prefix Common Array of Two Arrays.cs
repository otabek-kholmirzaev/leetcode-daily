// https://leetcode.com/problems/find-the-prefix-common-array-of-two-arrays/

public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        HashSet<int> setA = new();
        HashSet<int> setB = new();
        int n = A.Length;
        int[] ans = new int[n];
        int common = 0;
        for (int i = 0; i < n; i++) {
            setA.Add(A[i]);
            setB.Add(B[i]);

            if (setA.Contains(A[i]) && setB.Contains(A[i])) common++;
            if (A[i] != B[i] && setA.Contains(B[i]) && setB.Contains(B[i])) common++;

            ans[i] = common;
        }
        
        return ans;
    }
}