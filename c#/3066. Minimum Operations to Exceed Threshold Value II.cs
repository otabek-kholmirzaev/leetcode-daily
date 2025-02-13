public class Solution {
    public int MinOperations(int[] nums, int k) {
        PriorityQueue<long, long> pq = new();
        foreach (var num in nums) pq.Enqueue(num, num);
        int ans = 0;
        while (pq.Peek() < k && pq.Count >= 2) {
            long c = pq.Dequeue() * 2 +  pq.Dequeue();
            pq.Enqueue(c, c);
            ans++;
        }

        return ans;
    }
}