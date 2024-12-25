// https://leetcode.com/problems/find-largest-value-in-each-tree-row/

public class Solution {
    public IList<int> LargestValues(TreeNode root) {
        List<int> ans = new();
        if (root == null) return ans;
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            int count = queue.Count;
            int max = int.MinValue;
            for (int i = 0; i < count; i++) {
                var cur = queue.Dequeue();
                max = Math.Max(cur.val, max);
                if (cur.left != null) queue.Enqueue(cur.left);
                if (cur.right != null) queue.Enqueue(cur.right);
            }

            ans.Add(max);
        }

        return ans;
    }
}