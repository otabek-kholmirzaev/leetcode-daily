// https://leetcode.com/problems/binary-tree-preorder-traversal/

public class Solution {
    List<int> list;
    public IList<int> PreorderTraversal(TreeNode root) {
        list = new();
        preorder(root);
        return list;
    }

    void preorder(TreeNode node) {
        if (node == null) return;
        list.Add(node.val);
        preorder(node.left);
        preorder(node.right);
    }
}