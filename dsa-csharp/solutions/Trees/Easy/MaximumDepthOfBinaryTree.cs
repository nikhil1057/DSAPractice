// 104. Maximum Depth of Binary Tree
// https://leetcode.com/problems/maximum-depth-of-binary-tree/
//
// Given the root of a binary tree, return its maximum depth.
//
// APPROACH: Recursion (postorder). Depth of a node = 1 + max(left depth, right depth).
// Base case: null node has depth 0.
//
// TIME: O(n) — visit every node once
// SPACE: O(h) — recursion stack (h = height)

public class MaximumDepthOfBinaryTree
{
    public int MaxDepth(TreeNode? root)
    {
        if (root == null) return 0;
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}
