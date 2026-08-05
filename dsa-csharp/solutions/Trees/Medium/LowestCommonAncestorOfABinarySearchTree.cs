// 235. Lowest Common Ancestor of a Binary Search Tree
// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
//
// Given a binary search tree (BST), find the lowest common ancestor (LCA) node
// of two given nodes in the BST.
//
// APPROACH: Use BST property. At each node:
// - Both p and q are smaller → LCA is in left subtree
// - Both p and q are bigger → LCA is in right subtree
// - One on each side (or one equals current) → current IS the LCA
//
// TIME: O(h) — traverse height of tree
// SPACE: O(1) — iterative

public class LowestCommonAncestorOfABinarySearchTree
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if(root == null) return null;
        if(p.val > root.val && q.val > root.val) return LowestCommonAncestor(root.right, p, q);
        else if(p.val < root.val && q.val < root.val) return LowestCommonAncestor(root.left, p, q);
        else return root;
    }
}
