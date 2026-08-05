// 110. Balanced Binary Tree
// https://leetcode.com/problems/balanced-binary-tree/
//
// Given a binary tree, determine if it is height-balanced.
//
// APPROACH: Postorder recursion. Compute height at each node.
// If any node has |left_height - right_height| > 1, return -1 (unbalanced signal).
// If a child already returned -1, propagate it up.
// At the end: -1 means unbalanced, anything else means balanced.
//
// TIME: O(n) — visit every node once
// SPACE: O(h) — recursion stack (h = height)

public class BalancedBinaryTree
{
    public bool IsBalanced(TreeNode? root)
    {
        return Height(root) != -1;
    }

    private int Height(TreeNode? root)
    {
        if(root == null) return 0;

        int left = Height(root.left);
        int right = Height(root.right);

        if(left == -1 || right == -1) return -1;

        if( Math.Abs(left - right) > 1) return -1;

        return 1 + Math.Max(left,right);
    }
}
