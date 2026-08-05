// 98. Validate Binary Search Tree
// https://leetcode.com/problems/validate-binary-search-tree/
//
// Given the root of a binary tree, determine if it is a valid binary search tree (BST).
// A valid BST is defined as follows:
// - The left subtree of a node contains only nodes with keys less than the node's key.
// - The right subtree of a node contains only nodes with keys greater than the node's key.
// - Both the left and right subtrees must also be binary search trees.
//
// APPROACH: DFS with min/max bounds. Pass valid range down. Left child's max = parent val.
//           Right child's min = parent val. Use long to handle int edge cases.
// TIME: O(n)
// SPACE: O(h)

public class ValidateBinarySearchTree
{
    public bool IsValidBST(TreeNode? root)
    {
        if(root == null) return true;
        return isValid(root, long.MaxValue, long.MinValue);
    }

    private bool isValid(TreeNode root, long max, long min)
    {
        if (root == null) return true;

        if(root.val <= min || root.val >= max) return false;

        return
        isValid(root.left, root.val, min) &&
        isValid(root.right, max, root.val);
    }
}
