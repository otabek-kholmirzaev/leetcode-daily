// https://leetcode.com/problems/final-prices-with-a-special-discount-in-a-shop/

public class Solution {
    public int[] FinalPrices(int[] prices) {
        int n = prices.Length;
        
        for (int i = 0; i < n; i++) {
            int minIndex = -1;
            for (int j = i+1; j < n; j++) {
                if (prices[j] <= prices[i]) { minIndex = j; break; }
            }
            if (minIndex != -1) prices[i] -= prices[minIndex]; 
        }

        return prices;
    }
}