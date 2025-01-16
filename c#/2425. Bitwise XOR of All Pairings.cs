// https://leetcode.com/problems/bitwise-xor-of-all-pairings/

public class Solution {
    public int XorAllNums(int[] nums1, int[] nums2) {
        int xor1 = 0, xor2 = 0;
        foreach (var num in nums1) xor1 ^= num;
        foreach (var num in nums2) xor2 ^= num;

        int ans = 0;
        if (nums1.Length % 2 == 1) ans ^= xor2;
        if (nums2.Length % 2 == 1) ans ^= xor1;
        
        return ans;
    }
}