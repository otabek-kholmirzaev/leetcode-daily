// WATCH THIS VIDEO TO UNDERSTAND THE SOLUTION BETTER: https://youtu.be/mWUMfdloybo

// https://leetcode.com/problems/minimize-xor/

public class Solution {
    public int MinimizeXor(int num1, int num2) {
        int count = 0;
        while (num2 > 0) {
            count += (num2 & 1);
            num2 >>= 1;
        }

        int r = 0;
        for (int i = 30; i >= 0; i--) {
            if (count > 0 && (num1 & (1 << i)) > 0) {
                r |= (1 << i);
                count--;
            }
        }

        for (int i = 0; i <= 30; i++) {
            if (count > 0 && (num1 & (1 << i)) == 0) {
                r |= (1 << i);
                count--;
            }
        }

        return r;
    }
}