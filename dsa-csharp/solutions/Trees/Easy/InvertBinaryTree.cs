// 226. Invert Binary Tree
// https://leetcode.com/problems/invert-binary-tree/
//
// Given the root of a binary tree, invert the tree, and return its root.
//
// APPROACH: Recursion (preorder). At each node, swap left and right children,
// then recurse on both. Every subtree gets mirrored.
//
// TIME: O(n) — visit every node once
// SPACE: O(h) — recursion stack (h = height, worst case O(n) for skewed tree)

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class InvertBinaryTree
{
    public TreeNode? InvertTree(TreeNode? root)
    {
        if(root == null) return null;

        (root.right,root.left) = (root.left,root.right);
        InvertTree(root.left);
        InvertTree(root.right);

        return root;

    }
}
