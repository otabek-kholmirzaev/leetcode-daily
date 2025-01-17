https://leetcode.com/problems/neighboring-bitwise-xor/

public class Solution {
    public bool DoesValidArrayExist(int[] derived) {
        return derived.Sum() % 2 == 0;
    }
}