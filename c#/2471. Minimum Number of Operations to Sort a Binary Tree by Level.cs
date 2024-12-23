// https://leetcode.com/problems/minimum-number-of-operations-to-sort-a-binary-tree-by-level/

public class Solution {
    public int MinimumOperations(TreeNode root) {
        int ans = 0;
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            int count = queue.Count;
            List<int> vals = new();
            for (int i = 0; i < count; i++) {
                var cur = queue.Dequeue();
                vals.Add(cur.val);
                if (cur.left != null) queue.Enqueue(cur.left);
                if (cur.right != null) queue.Enqueue(cur.right);
            }

            ans += MinSwapsRequired(vals);
        }

        return ans;
    }

    private int MinSwapsRequired(List<int> list) {
        Dictionary<int, int> dict = new();
        int n = list.Count;
        for (int i = 0; i < n; i++) {
            dict[list[i]] = i;
        }

        var temp = new List<int>(list);
        temp.Sort();
        
        int ans = 0;
        
        for (int i = n-1; i >= 0; i--) {
            if (list[i] != temp[i]) {
                int j = dict[temp[i]];
                dict[list[i]] = j;
                dict[list[j]] = i;
                (list[i], list[j]) = (list[j], list[i]);
                ans++;
            }
        }

        return ans;
    }
}