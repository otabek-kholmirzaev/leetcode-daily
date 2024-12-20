// https://leetcode.com/problems/reverse-odd-levels-of-binary-tree/

public class Solution {
    public TreeNode ReverseOddLevels(TreeNode root) {
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int level = 0;
        while (queue.Count > 0) {
            List<TreeNode> list = new();
            while (queue.Count > 0) list.Add(queue.Dequeue());
            if (level % 2 == 1) {    
                int l = 0, r = list.Count - 1;
                while (l < r) { (list[l].val, list[r].val) = (list[r].val, list[l].val); l++; r--; }
            }

            foreach (var node in list) {
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }

            level++;
        }

        return root;
    }
}